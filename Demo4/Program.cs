﻿namespace Demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo
            #region Loop Statement
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //for (int i = 1; i <= 10; i++)
            //{
            //Console.WriteLine($"{i} T");
            //}


            #endregion
            #region for-foreach
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //   // Numbers[i] += 10;
            //   if (Numbers[i] == 5)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(Numbers[i] );
            //}

            //class implement interface iemurabel
            //foreach (int number in Numbers)
            //{
            //    number += 10;//invalid
            //    Console.WriteLine(number);
            //}
            #endregion
            #region While - Do while
            //Console.WriteLine("Please enter an even number");
            //int Numbner = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{Numbner} is even number");

            //int Number;
            //bool Flag;
            //do
            //{
            //Console.WriteLine("Please enter an even number");
            ////Number = int.Parse(Console.ReadLine());
            //Flag = int .TryParse(Console.ReadLine(), out Number);

            //}while(Number % 2 == 1 || !(Flag));
            //Console.WriteLine($"{Number} is even number"); 

            // Same exambel using while loop
            //int Number = 3;
            //bool Flag = false;
            //while (Number % 2 == 1 || !(Flag))
            //{
            //    Console.WriteLine("Please enter an even number");
            //    Flag = int.TryParse(Console.ReadLine(),out Number);
            //}
            //Console.WriteLine($"{Number} is even number");

            #endregion
            #region String
            // Class => Rerference type
            //Immutable data type [Value can not be changed]
            //Array of character

            //string Name;
            //Name = new string("Ali");
            //Name = "Ayman"; //Syntax sugar

            //string Name01 = "Ali";
            //string Name02 = "Ali";
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 hashCode : {Name01.GetHashCode()}");
            //Console.WriteLine("********************************************");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HashCode : {Name02.GetHashCode()}");
            //string Name01 = "Ahmed";
            //string Name02 = "Ali";
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 hashCode : {Name01.GetHashCode()}");
            //Console.WriteLine("********************************************");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HashCode : {Name02.GetHashCode()}");
            //Name02 = Name01;
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 hashCode : {Name01.GetHashCode()}");
            //Console.WriteLine("********************************************");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HashCode : {Name02.GetHashCode()}");

            //Name01 = "Mostafa";
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 hashCode : {Name01.GetHashCode()}");
            //Console.WriteLine("********************************************");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HashCode : {Name02.GetHashCode()}");
            //string Message = "Hello"; // unreachabel opject
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());
            //Console.WriteLine("********************");
            //Message += " root";
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());
            #endregion
            #region StringBuilder

            #endregion



            #endregion
        }
    }
}
