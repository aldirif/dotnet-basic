﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class MainDataType
    {
        public static void Main()
        {
            // Declaration with initializers (four examples):
            char firstLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 13, 15, 18, 21 };
            // ini adalah linQ
            var query = from item in source
                        where item <= limit
                        select item;
            Console.WriteLine("Query Result :" + query);
            foreach (var item in query)
            {
                Console.WriteLine("item value: " + item);
            }

            var query2 = from item in source
                         where item % 2 == 1
                         select item;
            Console.WriteLine("Write item with odd");
            foreach (var item in query2)
            {
                Console.WriteLine("item value: " + item);
            }

            var query3 = from item in source
                         where item % 2 == 0
                         select item;
            Console.WriteLine("Write item with even");
            foreach (var item in query3)
            {
                Console.WriteLine("item value: " + item);
            }

            var query4 = from item in source
                         where item % 3 == 0
                         select item;
            Console.WriteLine("Write item with multiple 3");
            foreach (var item in query4)
            {
                Console.WriteLine("item value: " + item);
            }

        }
    }
}
