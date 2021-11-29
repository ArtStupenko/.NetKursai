using System;
using System.Linq;

namespace array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite norimu skaiciu kieki : ");
            int n=int.Parse(Console.ReadLine());
            Console.Write($"Iveskite {n} masyvo skaicius : \n");
            Console.WriteLine("-----------------------------");
            int[] arr = new int[n];
            int[] arr2 = new int[n];
            int[] dviejuMasyvuSuma = new int[n];
            int[] rand = new int[n];

            Random randNum = new Random();
            for(int value = 0; value < n; value++)
            {
                rand[value]=randNum.Next(1, 100);
            }

            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Skaicius {i+1} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Atvirkstine tvarka : \n");
            Console.WriteLine("-----------------------");
            for (int j = n -1 ; j>-1; j--)
            {
                Console.WriteLine($"Skaicius {n-j}: {arr[j]}");
                suma +=arr[j];
            }
            Console.WriteLine("-----------------------");
            Console.Write($"Suma : {suma}\n");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Naujas Masyvas : ");
            Console.WriteLine("-----------------------");

            for (int overWrite = 0; overWrite < arr.Length; overWrite++)
            {
                arr2[overWrite] = arr[overWrite];
                Console.Write($"Naujo masyvo skaicius  {overWrite+1} : {arr2[overWrite]}\n");
            }
            Console.WriteLine("-----------------------");
            for (int rnd = 0; rnd < rand.Length; rnd++)
            {
                Console.Write($"RANDOM masyvo skaicius  {rnd + 1} : {rand[rnd]}\n");
            }
            Console.WriteLine("-----------------------");
            for (int ds = 0; ds < dviejuMasyvuSuma.Length; ds++)
            {
                dviejuMasyvuSuma[ds] = arr[ds] + rand[ds];
                Console.Write($"dvieju masvu skaicius  {ds + 1} suma : {dviejuMasyvuSuma[ds]}\n");
            }
            Console.WriteLine("-----------------------");
            Array.Sort(dviejuMasyvuSuma);
            for (int didejimoTvarka = 0; didejimoTvarka < rand.Length; didejimoTvarka++)
            {
                Console.Write($"Didejimo tvarka dvieju masyvu skaicius  {didejimoTvarka + 1} : {dviejuMasyvuSuma[didejimoTvarka]}\n");
            }
            Console.WriteLine("-----------------------");
            Array.Sort(rand);

            for (int didejimoTvarka = 0; didejimoTvarka < rand.Length; didejimoTvarka++)
            {
                Console.Write($"Didejimo tvarka RANDOM masyvo skaicius  {didejimoTvarka + 1} : {rand[didejimoTvarka]}\n");
            }
            Console.WriteLine("---------------------------------");
            Array.Reverse(rand);
            for (int mazejimoTvarka = 0; mazejimoTvarka < rand.Length; mazejimoTvarka++)
            {
                Console.Write($"Mazejimo tvarka RANDOM masyvo skaicius  {mazejimoTvarka + 1} : {rand[mazejimoTvarka]}\n");
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Didziausias RANDOM masyvo skaiciu : {rand.Max()}");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Maziausias RANDOM masyvo skaiciu : {rand.Min()}");
            Console.WriteLine("---------------------------------");
            for (int pasikartoja = 0; pasikartoja < rand.Length; pasikartoja++)
            {
                int kart = 0;
                for (int pasikartoja1 = 0; pasikartoja1 < rand.Length; pasikartoja1++)
                {
                    if (rand[pasikartoja1] == rand[pasikartoja])
                    {
                        kart++;
                    }
                }
                Console.WriteLine($"RANDOM masyvo skaicius {pasikartoja + 1} pasikartoja : {kart}");

            }
            Console.WriteLine("---------------------------------");

        }
        
    }
}
