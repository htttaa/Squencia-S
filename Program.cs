﻿using System; 

class DIO {

    static void Main(string[] args) { 

 double a, c, S= 1;
            for(int i=2; i<101;i++)
            {  
               S += 1.0/i;
            }
            a = Math.Round(S, 2);
            Console.WriteLine(a);
    }

}