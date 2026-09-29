using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Jarmu
    {

        private string rendszam;
        private int kor;
        private int kilometerOra;
        private int uzemanyagSzint;
        private bool szervizSzukseges;


        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
        {
            this.Rendszam = rendszam;
            this.Kor = kor;
            this.KilometerOra = kilometerOra;
            this.UzemanyagSzint = uzemanyagSzint;
        }

        public string Rendszam
        {
            get => rendszam;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("A rendszám nem lehet üres!");
                    rendszam = "ISMERETLEN";
                }
                else
                {
                    rendszam = value;
                }
            }
        }
        public int Kor
        {
            get { return kor; }
            set
            {
                if (value < 0)
                {
                    kor = 0;
                }
                else if (value > 50)
                {
                    kor = 50;
                }
                else
                {
                    kor = value;
                }
            }
        }
        public int KilometerOra
        {
            get { return kilometerOra; }
            set
            {
                if (value < 0)
                {
                    kilometerOra = 0;
                }
                else
                {
                    kilometerOra = value;
                }
            }
        }
        public int UzemanyagSzint
        {
            get { return uzemanyagSzint; }
            set
            {
                if (value < 0)
                {
                    uzemanyagSzint = 0;
                }
                else if (value > 100)
                {
                    uzemanyagSzint = 100;
                }
                else
                {
                    uzemanyagSzint = value;
                }
            }
        }

        public bool SzervizSzukseges
        {
            get { return szervizSzukseges; }
            set { if (kilometerOra > 10000) { szervizSzukseges = true; } else { szervizSzukseges = false; } }
        }

        public virtual void InformaciotAd()
        {
            Console.WriteLine($"{rendszam} - {kor} éves jármű, {kilometerOra} kilométerrel");
        }

        public virtual void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                kilometerOra -= 10000;
            }
            uzemanyagSzint -= 10;
        }
    }
}
