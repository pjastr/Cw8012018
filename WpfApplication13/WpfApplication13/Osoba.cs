using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApplication13
{
    class Osoba:IDataErrorInfo
    {
        public string Imie { get; set; }

        public int Wiek { get; set; }

        public Osoba(string imie, int wiek)
        {
            Imie = imie;
            Wiek = wiek;
        }

        public override string ToString()
        {
            return String.Format("Imię: {0}, Wiek: {1}", Imie, Wiek);
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get
            {
                string komunikat = String.Empty;
                switch (columnName)
                {
                    case "Imie":
                        if (string.IsNullOrEmpty(Imie))
                            komunikat = "Imię musi być wpisane!";
                        else if (Imie.Length < 3)
                            komunikat = "Imię musi mieć minimum 3 znaki!";
                        break;
                    case "Wiek":
                        if (Wiek < 0)
                            komunikat = "Wiek musi być dodatni";
                        break;
                };
                return komunikat;
            }
        }
    }
}
