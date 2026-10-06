namespace Program
{
    public class Kismotor : Jarmu
    {
        private int szam;

        public Kismotor(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int szam) : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            this.Szam = szam;
        }

        public int Szam
        {
            get { return szam; }
            set
            {
                if (value < 0)
                {
                    szam = 0;
                }
                else if (value > 20)
                {
                    szam = 20;
                }
                else
                {
                    szam = value;
                }
            }
        }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves teherautó, {KilometerOra} km-rel, es a valamilyen szam: {Szam}");
        }

        public override void Szervizel(int dij)
        {
            Szam += 10000;
            base.Szervizel(dij+Szam);
            Szam -= 10000;
        }

        
    }
}
