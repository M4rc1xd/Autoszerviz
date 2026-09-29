using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class TeherAuto : Jarmu
    {
        private int rakomany;

        public TeherAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int rakomany) : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            this.rakomany = rakomany;
        }

        public int Rakomany
        {
            get { return rakomany; }
            set
            {
                if (value < 0)
                {
                    rakomany = 0;
                }
                else if (value > 20)
                {
                    rakomany = 20;
                }
                else
                {
                    rakomany = value;
                }
            }
        }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves teherautó, {KilometerOra} km-rel Rakomany: {Rakomany} tonna.");
        }

        public override void Szervizel(int dij)
        {
            base.Szervizel(dij);
        }
    }
}
