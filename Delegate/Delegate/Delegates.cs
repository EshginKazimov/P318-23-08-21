using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //public delegate bool Check(int item);

    class Delegates
    {
        //static int Sum(int[] numbers)
        //public static int Sum(Check check, params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (int item in numbers)
        //    {
        //        if (check(item))
        //            sum += item; //sum = sum + item;
        //    }

        //    return sum;
        //}

        public static int Sum(Predicate<int> check, params int[] numbers)
        {
            int sum = 0;
            foreach (int item in numbers)
            {
                if (check(item))
                    sum += item; //sum = sum + item;
            }

            return sum;
        }

        //public static int Sum2(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (int item in numbers)
        //    {
        //        if (item % 2 != 0)
        //            sum += item; //sum = sum + item;
        //    }

        //    return sum;
        //}
    }
}
