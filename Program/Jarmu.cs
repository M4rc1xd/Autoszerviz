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
            this.rendszam = rendszam;
            this.kor = kor;
            this.kilometerOra = kilometerOra;
            this.uzemanyagSzint = uzemanyagSzint;
        }

        public string Rendszam
        {
            get { return rendszam; }
            set { if (string.IsNullOrEmpty(value))
                {
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
            set { if (value < 0)
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
            set { if (value < 0)
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
            set { if (value < 0)
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

        private string InformaciotAd()
        {
            return $"{rendszam} - {kor} éves jármű, {kilometerOra} kilométerrel";
        }

        private void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                kilometerOra -= 10000;
            }
            uzemanyagSzint -= 10;
        }
    }
}
