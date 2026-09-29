using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Szerviz
    {
        List<Jarmu> jarmuvek;

        private void jarmuFelvetele(Jarmu jarmu)
        {
            jarmuvek.Add(jarmu);
            Console.WriteLine($"A jarmu megerkezett a szervizbe");
        }

        private void informaciokListazasa()
        {
            foreach (var jarmu in jarmuvek)
            {
                jarmu.InformaciotAd();
            }
        }

        private void csoportosSzerviz(int dij)
        {
            foreach (var jarmu in jarmuvek)
            {
                if(jarmu.SzervizSzukseges)
                {
                    jarmu.Szervizel(dij);
                }

                else
                {
                    Console.WriteLine($"A {jarmu.Rendszam} nem szorul szervizre");
                }
            }
        }
    }
}
