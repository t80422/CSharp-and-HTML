﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//巢狀式迴圈控制流程 99乘法表
namespace CsConsole
{
    internal class 五五乘法表
    {
        public static void Main()
        {
            int outer = 1;
            while (outer <= 9)
            {
                int inner = 1;
                while (inner <= 9)
                {
                    Console.Write($"{outer}x{inner}={outer*inner}\t");
                    if(inner==5)
                    {
                        break;
                    }
                    inner++;
                }
                Console.WriteLine();
                if(outer==5)
                {
                    break;
                }
                outer++;
            }
        }
    }
}
