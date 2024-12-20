using System.Text;

namespace Demo4
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
            //StringBuilder Meassge;
            //Meassge = new StringBuilder("Hello");
            //Console.WriteLine(Meassge);
            //Console.WriteLine(Meassge.GetHashCode());
            ////Meassge += route; invalid
            //Meassge.Append(" root");
            //Console.WriteLine(Meassge);
            //Console.WriteLine(Meassge.GetHashCode());
            #endregion

            #region StringBuilderMethods
            //StringBuilder Message = new StringBuilder("Welcome");
            //Message.Append(" to route");
            //Console.WriteLine(Message);
            //Message.AppendLine(" Ali");
            //Message.Append(" saleh");
            //Console.WriteLine(Message);

            //Message.Remove(0, 7);
            //Console.WriteLine(Message);

            //Message.Insert(0, "Hello");
            //Console.WriteLine(Message);

            //int age = 22;
            //string Name = "Amir";
            //Message.AppendFormat("Name {0}, age {1}",Name, age);
            //Message.AppendJoin("/","21","11","89"); 
            //Console.WriteLine(Message);
            #endregion
            #region Array 1D
            //int[] Numbers = new int[3];
            //int[] Numbers = new int[3] { 1, 2, 3 };
            //int[] Numbers = new int[] { 1, 2, 3 };
            //int[] Numbers =  { 1, 2, 3 };
            //int[] Numbers = new int[3];

            //Numbers[0] = 1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;

            //for(int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine($"please enter a no {i+1} ");
            //    Numbers[i] = int.Parse( Console.ReadLine() );
            //}

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]); 
            //}
            //Console.WriteLine(Numbers.Length);
            //Console.WriteLine(Numbers.Rank);
            #endregion
            #region 2D Array
            //int[,] Marks = new int[3, 5];

            //Console.WriteLine(Marks.Length);
            //Console.WriteLine(Marks.Rank);
            //Console.WriteLine(Marks.GetLength(0));// Number of rows 
            //Console.WriteLine(Marks.GetLength(1));// Number of coulmns

            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    bool Flag;
            //    Console.WriteLine($"Enter grades of student {(i + 1)}");
            //    for (int j = 0; j < Marks.GetLength(1); /*j++*/)
            //    {
            //        Console.WriteLine($"enter grades of subject {(j + 1)}");
            //        //Marks[i,j] = int.Parse(Console.ReadLine());
            //        Flag = int.TryParse(Console.ReadLine(), out Marks[i, j]);//protictive code
            //        if (Flag && Marks[i, j] >= 0)
            //        {
            //            ++j;
            //        }

            //    }
            //}

            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($" grades of student {(i + 1)}");
            //    for (int j = 0; j < Marks.GetLength(1); j++)
            //    {
            //        Console.Write($"enter grades of subject {(j + 1)} :");
            //        Console.WriteLine(Marks[i,j]);
            //    }
            //}

            //for (int i = 0; i < Marks.Length; i++)
            //{
            //    Console.WriteLine(Marks[i/Marks.GetLength(1),i%Marks.GetLength(1)]);

            //}
            #endregion
            #region judge Array
            int[][] Numbers = new int[3][];
            Numbers[0]= new int[3]  { 1, 2 , 3};
            Numbers[1]= new int[2] {4 ,5};
            Numbers[2]= new int[1] { 6};
            for (int i =0; i < Numbers.Length; i++)
            {
                for (int j = 0; j < Numbers[i].Length; j++)
                {
                    Console.WriteLine(Numbers[i] [j]);
                }
            }
            #endregion
            #endregion
        }
    }
}
