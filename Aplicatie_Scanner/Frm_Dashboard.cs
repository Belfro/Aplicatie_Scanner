using AForge.Video;
using AForge.Video.DirectShow;
using Dapper;
using SixLabors.ImageSharp.ColorSpaces;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using ZXing;
using ZXing.Windows.Compatibility;

namespace Aplicatie_Scanner
{
    public partial class Frm_Dashboard : Form
    {
        List<DateFurnizori> furnizoriList = new List<DateFurnizori>();
        List<DateCalitate> CalitateList = new List<DateCalitate>();
        public Frm_Dashboard()
        {
            InitializeComponent();
        }

        List<DateDB> date = new List<DateDB>();

        List<DateDB> date_raport_faptic = new List<DateDB>();


        private void Frm_Dashboard_Load(object sender, EventArgs e)
        {
            SetcalendarToDefault();
            cbZonaSelectie.SelectedIndex = 0;
            
        }


        private void Frm_Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            bool Prima_Conditie_Selectata = false;
            string Conditii_Get_Date = "";

            if (checkBoxIntervalOrar.Checked && !CheckBoxReceptie.Checked)
            {
                SetcalendarToInterval();
            }
            else SetcalendarBack();


            if (!CheckBoxReceptie.Checked)
            {
                if (checkBoxFurnizor.Checked)
                {
                    Conditii_Get_Date = Conditii_Get_Date + $" AND Furnizor = '{cbFurnizor.SelectedItem.ToString()}'";
                    Prima_Conditie_Selectata = true;
                }

                if (checkBoxCalitate.Checked)
                {
                    Conditii_Get_Date = Conditii_Get_Date + $" AND Calitate = '{cbCalitate.SelectedItem.ToString()}'";
                }

                try
                {

                    DataAccess db = new DataAccess();
                    date = db.GetDateToataZiua(newCalendar1.SelectionStart, newCalendar1.SelectionEnd, Conditii_Get_Date, cbZonaSelectie.SelectedItem.ToString().Replace(" ", "_"));

                    UpdateBinding();
                    if (date.Count < 1) MessageBox.Show("Nu a fost gasit niciun produs !");
                    else btnPrintCSV.Visible = true;

                }
                catch
                {

                }
            }
            else
            {
                try
                {

                    DataAccess db = new DataAccess();
                    date = db.GetDateReceptie(newCalendar1.SelectionStart, newCalendar1.SelectionEnd, tbReceptie.Text);

                    UpdateBinding();
                    if (date.Count < 1) MessageBox.Show("Nu a fost gasit niciun produs !");
                    else btnPrintCSV.Visible = true;

                }
                catch
                {

                }
            }


        }

        private void UpdateBinding()
        {


            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = date;

                dataGridView1.Columns["Data"].DataPropertyName = "DoarData";
                dataGridView1.Columns["Timp"].DataPropertyName = "DoarTimp";
                dataGridView1.Columns["Locatie_Actuala"].DataPropertyName = "Locatie_Actuala";
                dataGridView1.Columns["Furnizor"].DataPropertyName = "Furnizor";
                dataGridView1.Columns["Numar_Aviz"].DataPropertyName = "Numar_Aviz";
                dataGridView1.Columns["Numar_Receptie"].DataPropertyName = "Numar_Receptie";
                dataGridView1.Columns["Numar_Bustean"].DataPropertyName = "Numar_Bustean";
                dataGridView1.Columns["Lungime"].DataPropertyName = "Lungime";
                dataGridView1.Columns["Diametru_Net"].DataPropertyName = "Diametru_Brut";
                dataGridView1.Columns["Calitate"].DataPropertyName = "Calitate";
                dataGridView1.Columns["Data_Transfer"].DataPropertyName = "Data_Transfer";
                dataGridView1.Columns["Specie"].DataPropertyName = "Specie";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBoxFurnizor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFurnizor.Checked)
            {
                cbFurnizor.Visible = true;
                try
                {
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConnStr")))
                    {
                        furnizoriList = connection.Query<DateFurnizori>($"select * from Furnizori").ToList();
                    }
                    cbFurnizor.Items.Clear();
                    foreach (DateFurnizori Date in furnizoriList)
                    {
                        cbFurnizor.Items.Add(Date.Denumire);
                    }
                    cbFurnizor.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (!checkBoxFurnizor.Checked)
                cbFurnizor.Visible = false;
        }

        private void checkBoxCalitate_CheckedChanged(object sender, EventArgs e)
        {
            cbCalitate.Visible = true;
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConnStr")))
                {
                    CalitateList = connection.Query<DateCalitate>($"select * from Calitate").ToList();
                }
                cbCalitate.Items.Clear();
                foreach (DateCalitate Date in CalitateList)
                {
                    cbCalitate.Items.Add(Date.Calitate);
                }
                cbCalitate.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            if (!checkBoxCalitate.Checked)
                cbCalitate.Visible = false;
        }
        private void SetcalendarToInterval()
        {
            DateTime start = new DateTime(newCalendar1.SelectionStart.Year
            , newCalendar1.SelectionStart.Month
            , newCalendar1.SelectionStart.Day
            , (int)numericUpDownStart.Value, 0, 0); //// Time

            DateTime end = new DateTime(newCalendar1.SelectionEnd.Year
                , newCalendar1.SelectionEnd.Month
                , newCalendar1.SelectionEnd.Day
                , (int)numericUpDownEnd.Value, 0, 0); //// Time

            newCalendar1.SelectionStart = start;
            newCalendar1.SelectionEnd = end;
        }

        private void SetcalendarToDefault()
        {
            DateTime d_final = DateTime.Now;
            d_final.AddDays(1);
            d_final = d_final.AddTicks(-1);
            newCalendar1.SelectionStart = DateTime.Today;
            newCalendar1.SelectionEnd = d_final;
        }
        private void SetcalendarBack()
        {
            DateTime start = new DateTime(newCalendar1.SelectionStart.Year
            , newCalendar1.SelectionStart.Month
            , newCalendar1.SelectionStart.Day
            , 0, 0, 0); //// Time

            DateTime end = new DateTime(newCalendar1.SelectionEnd.Year
                , newCalendar1.SelectionEnd.Month
                , newCalendar1.SelectionEnd.Day
                , 23, 59, 59); //// Time

            newCalendar1.SelectionStart = start;
            newCalendar1.SelectionEnd = end;
        }
        private void checkBoxIntervalOrar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIntervalOrar.Checked)
            {

                numericUpDownStart.Enabled = true;
                numericUpDownEnd.Enabled = true;


            }
            else
            {
                numericUpDownStart.Enabled = false;
                numericUpDownEnd.Enabled = false;
            }
        }
        private void cbZonaSelectie_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void btnPrintCSV_Click(object sender, EventArgs e)
        {
            String Cantitate_Lemn_Foc = "";

            ShowInputDialog(ref Cantitate_Lemn_Foc);

            string subPath = @$"C:\Azel\Raportari Romply\";

            bool exists = System.IO.Directory.Exists(subPath);

            if (!exists)
                System.IO.Directory.CreateDirectory(subPath);
            using (StreamWriter file = File.CreateText(@$"C:\Azel\Raportari Romply\Raport_Aplicatie_{DateTime.Now.ToString("yyyy-MM-dd_HH-mm")}.csv"))
            {
                if (CheckBoxReceptie.Checked) file.WriteLine($"Numar Receptie,{tbReceptie.Text},,,,,,,,,,,");

                file.WriteLine("Data,Ora,Furnizor,Numar Aviz,Numar Receptie,Numar Bustean,Lungime,Diametru Net,Diametru Brut,Volum Net,Volum Brut,Calitate,Locatie Actuala,Comentariu,Data Transfer,Specie_Bustean");
                foreach (var arr in date)
                {
                    file.WriteLine(string.Join(",", arr.FullString));
                }
                file.WriteLine($",,,,,,,,,,,,");
                file.WriteLine($",,,,NUMAR BUSTEAN CATARG:,{date.Select(i => i.Numar_Bustean).Distinct().Count()},,,,,,,");
                file.WriteLine($",,,,,,,,,,,,");
                file.WriteLine("Cantitati,Calitate,Lungime,Numar Bucati,Volum Net,Volum Brut,,,,,,,");
                foreach (var line in date.GroupBy(info => new { info.Lungime, info.Calitate })
                        .Select(group => new
                        {
                            Lungime = group.Key.Lungime,
                            Calitate = group.Key.Calitate,
                            Count = group.Count(),
                            Volum_Net = group.Sum(i => i.Volum_Net).ToString(),
                            Volum_Brut = group.Sum(i => i.Volum_Brut).ToString(),
                        })
                        .OrderBy(x => x.Calitate))
                {
                    file.WriteLine($",{line.Calitate},{line.Lungime},{line.Count.ToString()},{line.Volum_Net},{line.Volum_Brut}");
                }
                file.WriteLine($",,Total:,{date.Count()},{Math.Round(date.Select(i => i.Volum_Net).Sum(), 3)},{Math.Round(date.Select(i => i.Volum_Brut).Sum(), 3)},,,,,,,");
                file.WriteLine(",,,,,,,,,,,,");
                file.WriteLine($"Volum Total Furnir (MC): " +
                    $",{Math.Round(date.Where(i => i.Calitate == "Furnir" || i.Calitate == "Furnir A").Sum(i => i.Volum_Net), 4)}" +
                    ",Nr Bucati: " +
                    $",{date.Where(i => i.Calitate == "Furnir" || i.Calitate == "Furnir A").Count()}" +
                    "\nVolum Total Gater (MC): " +
                    $",{Math.Round(date.Where(i => i.Calitate == "Gater").Sum(i => i.Volum_Net), 4)}" +
                    ",Nr Bucati: " +
                    $",{date.Where(i => i.Calitate == "Gater").Count()}" +
                    $"\nVolum Lemn Foc: " +
                    $",{(Math.Round(date.Where(i => i.Calitate == "Lemn Foc").Sum(i => i.Volum_Net), 4) + Convert.ToDouble(Cantitate_Lemn_Foc)).ToString()}");

            }
        }

        private void CheckBoxReceptie_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxReceptie.Checked)
            {
                checkBoxCalitate.Enabled = false;
                checkBoxFurnizor.Enabled = false;
                cbZonaSelectie.Enabled = false;
                newCalendar1.Enabled = true;
                tbReceptie.Visible = true;
                cbFurnizor.Enabled = false;
                cbCalitate.Enabled = false;
                checkBoxIntervalOrar.Enabled = false;
                checkBoxIntervalOrar.Checked = false;

            }
            else
            {
                checkBoxCalitate.Enabled = true;
                checkBoxFurnizor.Enabled = true;
                cbZonaSelectie.Enabled = true;
                newCalendar1.Enabled = true;
                tbReceptie.Visible = false;
                cbFurnizor.Enabled = true;
                cbCalitate.Enabled = true;
                checkBoxIntervalOrar.Enabled = true;

            }
        }
        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 100);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Cantitate Lemn Foc";
            inputBox.StartPosition = FormStartPosition.CenterParent;
            inputBox.MinimizeBox = false;
            inputBox.MaximizeBox = false;

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = "";
            inputBox.Controls.Add(textBox);

            System.Windows.Forms.Button okButton = new System.Windows.Forms.Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(size.Width / 2, 40);
            okButton.Text = "&Introducere";
            okButton.Location = new System.Drawing.Point(size.Width / 4, 39);
            inputBox.Controls.Add(okButton);

            /*  System.Windows.Forms.Button cancelButton = new System.Windows.Forms.Button();
              cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
              cancelButton.Name = "cancelButton";
              cancelButton.Size = new System.Drawing.Size(75, 23);
              cancelButton.Text = "&Cancel";
              cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
              inputBox.Controls.Add(cancelButton);*/

            inputBox.AcceptButton = okButton;
            //inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            if (double.TryParse(textBox.Text, out double n))
                input = textBox.Text;
            else
                input = 0.ToString();
            return result;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbReceptie_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrintRaportFaptic_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new DataAccess();

                date_raport_faptic = db.GetDateRaportFaptic();

                string subPath = @$"C:\Azel\Raportari Romply\Rapoarte Depozit";

                bool exists = System.IO.Directory.Exists(subPath);

                if (!exists)
                    System.IO.Directory.CreateDirectory(subPath);
                using (StreamWriter file = File.CreateText(@$"C:\Azel\Raportari Romply\Rapoarte Depozit\Raport_Depozit_{DateTime.Now.ToString("yyyy-MM-dd_HH-mm")}.csv"))
                {
                    file.WriteLine("Data,Ora,Furnizor,Numar Aviz,Numar Receptie,Numar Bustean,Lungime,Diametru Net,Diametru Brut,Volum Net,Volum Brut,Calitate,Locatie Actuala");

                    foreach (var arr in date_raport_faptic)
                    {
                        file.WriteLine(string.Join(",", arr.FullString_Raport_Faptic));
                    }
                    file.WriteLine(",,,,,");
                    file.WriteLine(",,,,,");

                    file.WriteLine(",Calitate,Lungime,Numar Bucati,Volum Net,Volum Brut,,,,,,,");
                    foreach (var line in date_raport_faptic.GroupBy(info => new { info.Lungime, info.Calitate })
                            .Select(group => new
                            {
                                Calitate = group.Key.Calitate,
                                Lungime = group.Key.Lungime,
                                Count = group.Count(),
                                Volum_Net = group.Sum(i => i.Volum_Net).ToString(),
                                Volum_Brut = group.Sum(i => i.Volum_Brut).ToString(),
                            })
                            .OrderBy(x => x.Calitate))
                    {
                        file.WriteLine($",{line.Calitate},{line.Lungime},{line.Count.ToString()},{line.Volum_Net},{line.Volum_Brut}");
                    }
                    file.WriteLine($",,Total:,{date_raport_faptic.Count()},{Math.Round(date_raport_faptic.Select(i => i.Volum_Net).Sum(), 3)},{Math.Round(date_raport_faptic.Select(i => i.Volum_Brut).Sum(), 3)},,,,,,,");
                    file.WriteLine(",,,,,,,,,,,,");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

        }
    }

}
