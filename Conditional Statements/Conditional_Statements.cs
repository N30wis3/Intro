namespace Conditional_Statements
{
    internal class Conditional_Statements
    {
        static void Main(string[] args)
        {
            //1 int
            Console.WriteLine("Opgave 1 \n" + AbsoluteValue(0) + "\n \n");

            //2 ints
            Console.WriteLine("Opgave 2 \n" + DivBy2or3(7, 12) + "\n \n");

            //1 string
            Console.WriteLine("Opgave 3 \n" + IfUpper() + "\n \n");

            //3 ints
            Console.WriteLine("Opgave 4 \n" + GreaterThanThird() + "\n \n");

            //1 int
            Console.WriteLine("Opgave 5 \n" + OddOrEven() + "\n \n");

            //3 ints
            Console.WriteLine("Opgave 6 \n" + IsAscOrder() + "\n \n");

            //i int
            Console.WriteLine("Opgave 7 \n" + PosiNegaZero(2) + "\n \n");

            //i int
            Console.WriteLine("Opgave 8 \n" + LeapYear() + "\n \n");
        }

        //Opgave 1
        static int AbsoluteValue(int x)
        {
            return Math.Abs(x);
        }

        //Opgave 2
        static int DivBy2or3(int FirstNum = 15, int SecNum = 30)
        {
            if ((FirstNum % 2 == 0 || FirstNum % 3 == 0) && (SecNum % 2 == 0 || SecNum % 3 == 0))
            {
                return FirstNum * SecNum;
            }
            else
            {
                return FirstNum + SecNum;
            }
        }

        //Opgave 3
        static string IfUpper(string TreBogstaver = "ABC")
        {
            if (TreBogstaver.Length != 3)
            {
                return "Ugyldigt input. Inputlængde skal være 3";
            }

            int x = 0;
            for (int i = 0; i < 3; i++)
            {
                if (Char.IsUpper(TreBogstaver[i]))
                {
                    x++;
                }
            }
            if (x == 3)
            {
                return "True: " + TreBogstaver + " is upper";
            }
            else
            {
                return "False: " + TreBogstaver + " is not upper";
            }
        }

        //Opgave 4
        static bool GreaterThanThird(int FirstNum = 2, int SecNum = 7, int LastNum = 12)
        {
            if (FirstNum + SecNum > LastNum || FirstNum * SecNum > LastNum)
            {
                return true;
            } else { return false; }
        } 

        //Opgave 5
        static string OddOrEven(int x = 721)
        {
            if(x % 2 == 0)
            {
                return x.ToString() + " is even";
            } else
            {
                return x.ToString() + " is odd";
            }
        }

        //Opgave 6
        static bool IsAscOrder(int FirstNum = 3, int SecNum = 7, int LastNum = 10)
        {
            if (FirstNum < SecNum && SecNum < LastNum)
            {
                return true;
            } else
            {
                return false;
            }
        }

        //Opgave 7
        static string PosiNegaZero(int x)
        {
            if (x > 0)
            {
                return x.ToString() + " er positiv";
            }
            else if (x < 0)
            {
                return x.ToString() + " er negativt";
            }
            else 
            { 
                return x.ToString() + " er nul"; 
            }
        }

        //Opgave 8
        static bool LeapYear(int year = 2016)
        {
            int RefYear = 2000;
            bool IsALeapYear = false;
            if (year < RefYear)
            {
                while (year < RefYear)
                {
                    RefYear -= 4;
                    if (RefYear == year)
                    {
                        IsALeapYear = true;
                    }
                }
            }
            else if (year > RefYear)
            {
                while (year > RefYear)
                {
                    RefYear += 4;
                    if (RefYear == year)
                    {
                        IsALeapYear = true;
                    }
                }
            }
            else { IsALeapYear = true; }
            return IsALeapYear;
        }
    }
}
