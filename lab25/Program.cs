using System;
namespace ConsoleApplication1
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Введіть кількість елементів масиву");

            int n = Convert.ToInt32(Console.ReadLine());
            //const int n = m; 

            int[] a = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(-100, 100);

            }

            int x1 = 0;
            int x2 = 0;
            int x = 0;

            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0 && x == 0)
                {
                    x1 = i;
                    x++;
                }
                if (a[i] < 0 && x == 1)
                {
                    x2 = i;
                }
            }
            int sum = 0;
            for (int i = x1 + 1; i < x2; i++)
            {
                sum = sum + a[i];



            }



            int max = a[0]; // максимальний елемент
            for (int i = 0; i < n; i++)
                if (a[i] > max) max = a[i];
            Console.WriteLine("Максимальний елемент = " + max);
            Console.WriteLine("Сума в межах від " + x1 + " до " + x2 + " = " + sum);
        }
    }
}
