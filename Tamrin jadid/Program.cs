using System;
namespace project
{
    class Test
    {
        public static void Main()
        {
            double[,] a = new double[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("element {0},{1} = ", i + 1, j + 1);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Calc(a);
        }
        private static void Calc(double[,] a)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i + 1, j + 1] = (a[i, j] + a[i, j + 1] + a[i, j + 2] + a[i + 1, j] + a[i + 2, j] + a[i + 2, j + 1] + a[i + 2, j + 2] + a[i + 1, j + 2]) / 8;
                    /* Moadele araye =  a[i + 1, j + 1] = (a[i, j] + a[i, j + 1] +
                    a[i, j + 2] + a[i + 1, j] + a[i + 2, j] +
                    a[i + 2, j + 1] + a[i + 2, j + 2] + a[i + 1, j + 2])/ 8;*/
        }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("new element {0},{1} = {2} ", i + 1, j + 1, a[i, j]);
                }
            }
        }
    }
}