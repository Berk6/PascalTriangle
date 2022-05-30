using System;

namespace Fibonacci
{
    internal class Program
    {

        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(x, y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            int sira = 0;
        hata:
            Console.WriteLine("Fibonacci Dizisinin kaç basamak ilerlemesini istiyorsunuz?\n(girdiğiniz sayi 20 den kucuk olmalıdır!)");
            try
            {
                sira = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Lütfen bir sayi girin!!");
                goto hata;
            }
            int[] dizi = new int[sira];
            for (int i = 0; i < sira; i++)
            {
                dizi[i] = 1;
            }
            int sayi1 = 1;
            WriteAt($"{sayi1}", 3 * (sira+1), 10);
            WriteAt($"{sayi1}", 3 * sira, 12);
            WriteAt($"{sayi1}", 3 * (sira + 2), 12);
            for (int i = 3; i < sira + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (j < i / 2)
                    {
                        dizi[j + 1] = dizi[i - j - 2] + dizi[j + 1];
                    }
                    else
                    {
                        dizi[j] = dizi[i - j - 1];
                    }
                    WriteAt($"{dizi[j]}", 3 * (sira - i + 2 + j * 2), 2 * (i+4));
                }
            }
        }
    }
}
