using System;
using System.Reflection.Metadata;

namespace Home_work_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task 1 beginning
            //Console.WriteLine("Please enter the number: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //bool b = IsPrime(n);

            //if (b)
            //{
            //    Console.WriteLine("The number you entered is Prime");
            //}
            //else
            //{
            //    Console.WriteLine("The number you entered is Composite");
            //}
            #endregion


            #region Task 2 beginning
            int average = CalcAvg(new[] { 20, 30 });


            if (average > 60)
            {

                Console.WriteLine("Mezun oldunuz");
            }
            else
            {
                Console.WriteLine("Mezun ola bilmediniz");
            }
            #endregion
        }


        #region Task1
        /*    IsPrime method -parametr olaraq integer value qəbul edir
        Göndərilmiş integer dəyərin sadə olub olmadığını qaytarır.Ədəd sadədirsə true, deyilsə false qayıtmalıdır*/


        //static bool IsPrime(int n)
        //{

        //    for (int i = 2; i <= n / 2; i++)
        //    {
        //        int remainder = n % i;
        //        int count = 0;

        //        if (remainder == 0)
        //        {
        //            count++;

        //            if (count != 0)
        //            {
        //                return false;
        //            }
        //            else
        //            {
        //                return true;
        //            }

        //        }

        //    }
        //    return true;
        //}
        #endregion


        #region Task 2
        /* CalcAvg methodu - Göndərilmiş imtahanlar qiyməti siyah ısına (integer array) əsasən həmin qiymətlərin ortalamasını qaytaran metod yazın. 
        Main metodunda bu metodu call edib, burdan qayıdan dəyərə əsasən ortalama 60-dan böyükdürsə console-da "Mezun oldunuz" əks halda 
        "Mezun ola bilmediniz" yazısı yazdırın*/
        static int CalcAvg(int[] scores)
        {
            int sum = 0;
            int count = scores.Length;
            int result = 1;
            foreach (int score in scores)
            {
                sum += score;
                result = sum / count;
            }

            return result;

        }
        #endregion
    }
}
