using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication17
{
    class Osoba
    {
        private string imie;
        private string nazwisko;
        private DateTime dataUrodzenia;

        public Osoba() { }

        public void UstawDane(string imie, string nazwisko, DateTime dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
        }

        public override string ToString()
        {
            return "Imię: "+imie+Environment.NewLine+"Nazwisko: "+nazwisko+Environment.NewLine+"Data urodzenia: "+dataUrodzenia;
        }


    }
}
