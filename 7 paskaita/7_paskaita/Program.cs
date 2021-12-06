using System;

namespace _7_paskaita
{
    internal class Program
    {
        public struct Vidurkis
        {
            public double Trimestras1;
            public double Trimestras2;
            public double Trimestras3;


            public Vidurkis(double trimestras1, double trimestras2, double trimestras3)
            {
                Trimestras1 = trimestras1;
                Trimestras2 = trimestras2;
                Trimestras3 = trimestras3;
            }
            public void KoksVidurkis()
            {
                double Metinis;
                Metinis = Math.Round(((Trimestras1 + Trimestras2 + Trimestras3) / 3), 2);
                Console.WriteLine($"Vidurkis : {Metinis}");
            }

            static void Main(string[] args)
            {
                Vidurkis vidurkis;
                vidurkis.Trimestras1 = 9;
                vidurkis.Trimestras2 = 6;
                vidurkis.Trimestras3 = 4;

                Vidurkis vidurkis1 = new Vidurkis(8, 7, 6);

                vidurkis.KoksVidurkis();
                vidurkis1.KoksVidurkis();

            }


        }
    }
}
