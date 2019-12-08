using System;

namespace Lab_4
{
    class Program
    {
        static int[] Kopiuj(int[] tablica) 
        {
            int[] nowa = new int[tablica.Length];
            for (int i = 0; i < nowa.Length; i++)
            {
                nowa[i] = tablica[i];
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            int[][] z = new int[5][];
            for (int i = 0; i < z.Length; i++)
            {
                z[i] = new int[i + 1];
                for (int i = 0; i < z.Length; i++)
                {
                    z[i][j] = i + j;
                }
            }

            for (int i = 0; i < Z.Length; i++)
            {
                int skopiowana = Kopiuj(z);
            }
            
        }
    }
}
