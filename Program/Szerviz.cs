using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Szerviz
    {
        List<Jarmu> jarmuvek;

        public void JarmuFelvetele(Jarmu jarmu)
        {
            jarmuvek.Add(jarmu);
            Console.WriteLine($"A jarmu megerkezett a szervizbe");
        }

        public void InformaciokListazasa()
        {
            foreach (var jarmu in jarmuvek)
            {
                jarmu.InformaciotAd();
            }
        }

        public void CsoportosSzerviz(int dij)
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
