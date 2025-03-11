using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Zebra.Sdk.Comm;

namespace Aplicatie_Scanner
{
    public class DataAccess
    {
       public List<DateDB> GetDateToataZiua(DateTime DataSetata1, DateTime DataSetata2, String Conditii_Where, String Zona_Selectie)
        {

            try
            { 
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConnStr")))
                {


                    var output = connection.Query<DateDB>($"" +
                        $"select * from {Zona_Selectie} " +
                        $"WHERE Data_Transfer BETWEEN '{DataSetata1.ToString("yyyy-MM-dd HH:mm:ss.fff")}' AND '{DataSetata2.ToString("yyyy-MM-dd HH:mm:ss.fff")}' " +
                        $"{Conditii_Where} " +
                        $"ORDER BY Data_Transfer").ToList();
                    foreach (var i in output)
                    {
                        i.Lungime = Math.Round(i.Lungime, 2);
                    }
                    return output;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Connecting to the Database ! Error:" + ex.Message);
                return null;
            }
        }
        public List<DateDB> GetDateReceptie(DateTime DataSetata1, DateTime DataSetata2, string Receptie)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConnStr")))
                {
                    var output = connection.Query<DateDB>($"" +
                        $"SELECT * FROM Depozit WHERE Numar_Receptie = '{Receptie}' AND ( Data_Transfer BETWEEN '{DataSetata1.ToString("yyyy-MM-dd HH:mm:ss.fff")}' AND '{DataSetata2.ToString("yyyy-MM-dd HH:mm:ss.fff")}' ) " +
                        $" UNION " +
                        $"SELECT * FROM Linie_Productie_1 WHERE Numar_Receptie = '{Receptie}' AND ( Data_Transfer BETWEEN '{DataSetata1.ToString("yyyy-MM-dd HH:mm:ss.fff")}' AND '{DataSetata2.ToString("yyyy-MM-dd HH:mm:ss.fff")}' ) " +
                        $" UNION " +
                        $"SELECT * FROM Linie_Productie_2 WHERE Numar_Receptie = '{Receptie}' AND ( Data_Transfer BETWEEN '{DataSetata1.ToString("yyyy-MM-dd HH:mm:ss.fff")}' AND '{DataSetata2.ToString("yyyy-MM-dd HH:mm:ss.fff")}' ) " +
                        $" UNION " +
                        $"SELECT * FROM Linie_Productie_3 WHERE Numar_Receptie = '{Receptie}' AND ( Data_Transfer BETWEEN '{DataSetata1.ToString("yyyy-MM-dd HH:mm:ss.fff")}' AND '{DataSetata2.ToString("yyyy-MM-dd HH:mm:ss.fff")}' ) " +
                        $" ORDER BY Locatie_Actuala").ToList();
                    foreach (var i in output)
                    {
                        i.Lungime = Math.Round(i.Lungime, 2);
                    }
                    return output;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Connecting to the Database ! Error:" + ex.Message);
                return null;
            }
        }

        public async Task<List<DateFurnizori>> GetDateFurnizori()
        {

            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConnStr")))
                {

                    var output = connection.Query<DateFurnizori>($"SELECT Denumire FROM Furnizori ORDER BY Denumire").ToList();
                    return output;
                }

            }
            catch (Exception ex)
            {

                return null;
            }

        }

        public async Task<List<DateCalitate>> GetDateCalitate()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConnStr")))
                {
                    var output = connection.Query<DateCalitate>($"SELECT Calitate FROM Calitate").ToList();
                    // "Data Source=192.168.100.55,1433;Network Library=DBMSSOCN;Initial Catalog=Siemens_PLC;User ID=siemens;Password=siemens;"
                    return output;
                }
            }
            catch (Exception ex)
            {


                 // MessageBox.Show("Error Connecting to the Database ! Error:" + ex.Message);
                return null;
            }


        }
        public async Task<List<DateLungime>> GetDateLungime()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConnStr")))
                {
                    var output = connection.Query<DateLungime>($"SELECT Lungime FROM Lungimi Order by Lungime").ToList();
                    for (var i = 0; i < output.Count; i++)
                    {
                        output[i].Lungime = Math.Round(output[i].Lungime, 2);
                    }

                    return output;
                }
            }
            catch (Exception ex)
            {


                // MessageBox.Show("Error Connecting to the Database ! Error:" + ex.Message);
                return null;
            }


        }
        public List<DateDB> GetDateRaportFaptic()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConnStr")))
                {
                    var output = connection.Query<DateDB>($"" +
                        $"SELECT * FROM Raport_Depozit" +
                        $" ORDER BY Data_Timp").ToList();

                    foreach (var i in output)
                    {
                        i.Lungime = Math.Round(i.Lungime, 2);
                    }

                    return output;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Connecting to the Database ! Error:" + ex.Message);
                return null;
            }
        }

        public List<DateDB> GetDateRaportDepozit()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConnStr")))
                {
                    var output = connection.Query<DateDB>($"" +
                        $"SELECT * FROM Depozit" +
                        $" ORDER BY Data_Timp").ToList();

                    foreach (var i in output)
                    {
                        i.Lungime = Math.Round(i.Lungime, 2);
                    }

                    return output;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Connecting to the Database ! Error:" + ex.Message);
                return null;
            }
        }

        internal List<DateDB> GetDate(object text)
        {
            throw new NotImplementedException();
        }


    }
}
