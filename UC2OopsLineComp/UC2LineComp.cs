﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsLineComp
{

    public class UC2OopsLineComp
    {
       


        public double Length()
        {
            Console.WriteLine("Enter Value of : X1");
            //string value converted to integer

            int X1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of : X2");
            int X2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of : Y1");
            int Y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of : Y2");
            int Y2 = Convert.ToInt32(Console.ReadLine());
            //using double to get square root value in double decimal points
            double length = Math.Sqrt((Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2)));

            return length;

        }
    }
}