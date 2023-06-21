using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie_Scanner
{
    
    public class DateDB
    {
        public DateTime Data_Timp { get; set; }


        public string Furnizor { get; set; }
        public string Numar_Aviz { get; set; }
        public string Numar_Receptie { get; set; }
        public double Numar_Bustean { get; set; }
        public double Lungime { get; set; }
        public double Diametru_Brut { get; set; }
        public double Diametru_Net { get; set; }
        public string Calitate { get; set; }
        public string GUID { get; set; }
        public string Locatie_Actuala { get; set; }
        public string Comentariu { get; set; }
        public DateTime Data_Transfer { get; set; }
        public string Doardata
        {
            get
            {
                // Stringul afisat 
                return $"{Data_Timp.Day.ToString("D2")}/{Data_Timp.Month.ToString("D2")}/{Data_Timp.Year}";
            }
        }
        public string DoarTimp
        {
            get
            {
                // Stringul afisat 
                return $"{Data_Timp.Hour.ToString("D2")}:{Data_Timp.Minute.ToString("D2")}:{Data_Timp.Second.ToString("D2")}";
            }
        }
        public double Volum_Net
        {
            get
            {
                return Math.Round(((Diametru_Net / 100) * (Diametru_Net / 100) * 3.14159 * Lungime / 4), 3);
            }
        }
        public double Volum_Brut
        {
            get
            {
                return Math.Round(((Diametru_Brut / 100) * (Diametru_Brut / 100) * 3.14159 * Lungime / 4),3);
            }
        }
        public string FullString
        {
            get
            {
                // Stringul afisat 
                return $"{Doardata},{DoarTimp},{Furnizor},{Numar_Aviz},{Numar_Receptie},{Numar_Bustean},{Math.Round(Lungime,2)},{Diametru_Net},{Diametru_Brut},{Volum_Net},{Volum_Brut},{Calitate},{Locatie_Actuala},{Comentariu},{Data_Transfer}";
            }
        }
    }
    public class DateFurnizori
    { 
        public float Index { get; set; }
        public DateTime Data_Timp { get; set; }
        public string Denumire { get; set; }
        public string Localitate { get; set; }


        public string Doardata
        {
            get
            {
                // Stringul afisat 
                return $"{Data_Timp.Day.ToString("D2")}/{Data_Timp.Month.ToString("D2")}/{Data_Timp.Year}";
            }
        }
        public string DoarTimp
        {
            get
            {
                // Stringul afisat 
                return $"{Data_Timp.Hour.ToString("D2")}:{Data_Timp.Minute.ToString("D2")}:{Data_Timp.Second.ToString("D2")}";
            }
        }
    }

    public class DateCalitate
    {
        public float Index { get; set; }

        public string Calitate { get; set; }
    }

    public class DateLungime
    {
        public double Lungime{ get; set; }
    }
}
