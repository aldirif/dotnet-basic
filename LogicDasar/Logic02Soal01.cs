﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    public class Logic02Soal01
    {
        public Logic02Soal01()
        {
        }

        public static void CetakData(int n)
        {
            Console.WriteLine("Logic02Soal01" + "\n");
            for (int i = 0; i < n; i++)
            {
                int angka = 1;
                for (int j = 0; j < n; j++)
                {
                    if (i == j || i + j == n - 1)
                    {
                        Console.Write(angka + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }

                    angka += 1;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
