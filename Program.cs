using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Largest
            //Console.WriteLine("Ededlerinizi daxil edin");
            //int[] array = new int[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    string num = Console.ReadLine();
            //    int new_num = int.Parse(num);
            //    array[i] = new_num;
            //}
            //Console.WriteLine(Largest(array));
            #endregion

            #region Sum of nums
            //Console.WriteLine("Ededi daxil edin");
            //string num = Console.ReadLine();
            //int req = int.Parse(num);
            //Console.WriteLine(sumofnums(req));
            #endregion

            #region Price
            //Console.WriteLine("Ededi daxil edin");
            //string num1 = Console.ReadLine();
            //double req1 = double.Parse(num1);
            //string num2 = Console.ReadLine();
            //double req2 = double.Parse(num2);
            //string num3 = Console.ReadLine();
            //double req3 = double.Parse(num3);
            //Console.WriteLine(Price(req1, req2, req3));
            #endregion
        }
        #region Price
        //static double Price(double numb1, double numb2, double numb3)
        //{
        //    double sum = 0;
        //    if (numb2 > numb1 && numb2 > numb3)
        //    {
        //        if (numb1 > numb3)
        //        {
        //            sum = numb2 + numb1;
        //        }
        //        else
        //        {
        //            sum = numb2 + numb3;
        //        }
        //    }
        //    else if (numb1 > numb2 && numb1 > numb3)
        //    {
        //        if (numb2 > numb3)
        //        {
        //            sum = numb1 + numb2;
        //        }
        //        else
        //        {
        //            sum = numb1 + numb3;
        //        }
        //    }
        //    else if (numb3 > numb2 && numb3 > numb1)
        //    {
        //        if (numb2 > numb1)
        //        {
        //            sum = numb3 + numb2;
        //        }
        //        else
        //        {
        //            sum = numb3 + numb1;
        //        }
        //    }return sum;
        //}
        #endregion

        #region Sum of nums
        //static int sumofnums(int a)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < a; i++)
        //    {
        //        int m = a % 10;
        //        a = (a - m) / 10;
        //        sum += m;
        //    }
        //    return sum;
        //}
        #endregion

        #region Largest
        //static int Largest(int[] tema)
        //{
        //for (int i = 0; i < tema.Length;)
        //{
        //    int biggest = 0;
        //    if (tema[i] > tema[i + 1] && tema[i] > tema[i + 2])
        //    {
        //        biggest += tema[i];
        //        return biggest;
        //    }
        //    if (tema[i + 1] > tema[i] && tema[i + 1] > tema[i + 2])
        //    {
        //        biggest += tema[i + 1];
        //        return biggest;
        //    }
        //    if (tema[i + 2] > tema[i] && tema[i + 2] > tema[i + 1])
        //    {
        //        biggest += tema[i + 2];
        //        return biggest;
        //    }
        //}
        //return 0;
        //}
        #endregion
    }
}
