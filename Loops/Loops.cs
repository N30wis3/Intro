namespace Loops
{
    internal class Loops
    {
        static void Main(string[] args)
        {
            //1 int
            Console.WriteLine("Opgave 1 \n" + MultiTable() + "\n\n");

            //op til 6 ints
            Console.WriteLine("Opgave 2 \n" + BiggestNum([1, 2, 3, 4, 5, 6]) + "\n \n");

            //1 int
            Console.WriteLine("Opgave 3 \n" + TwoOrMoreSeven() + "\n\n");

            Console.WriteLine("Opgave 4 \n" + IncreaseByOne() + "\n \n");

            //1 int
            Console.WriteLine("Opgave 5 \n" + PrimeNumbers() + "\n \n");
            
            //1 string
            Console.WriteLine("Opgave 6 \n" + ExtractString() + "\n \n");
            
            //2 strings
            Console.WriteLine("Opgave 7 \n" + FullLetters("a", "å") + "\n \n");

            //2 ints
            Console.WriteLine("Opgave 8 \n" + SumAndAvg() + "\n \n");

            //1 int, 1 string
            Console.WriteLine("Opgave 9 \n" + Pyramid() + "\n");

            //2 int
            Console.WriteLine("Opgave 10 \n" + PowerOf() + "\n \n");
        }

        //Opgave 1
        static string MultiTable(int x = 10)
        {
            string MultTable = "";
            for (int i = 1; i <= x; i++) 
            {
                for (int ii = 1; ii <= x; ii++) { 
                    MultTable += (i * ii).ToString() + " ";
                }
                MultTable += "\n";
            }
            return MultTable;
        }

        //Opgave 2
        static int BiggestNum(int[] nums)
        { 
            int x = 0;
            foreach (int num in nums)
            {
                if (num > x)
                {
                    x = num;
                }
            }
            return x;
        }

        //Opgave 3
        static int TwoOrMoreSeven(int max = 10)
        {
            int x = 0;
            Random Rnumbers = new Random();
            int[] numbers = new int[max];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Rnumbers.Next(1, 11);
            }
            Console.WriteLine("Random int array til opgave 3");
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 7 && numbers[i + 1] == 7)
                {
                    x++;
                }
            }
            return x;
        }

        //Opgave 4
        static bool IncreaseByOne()
        {
            int x = 0;
            int[] nums = { 5, 4, 3, 1, 2, 3 };

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i + 1] - nums[i] == 1 && nums[i + 2] - nums[i + 1] == 1)
                {
                    x++;
                }
            }
            if (x != 0)
            {
                return true;
            } else { return false; }
            
        }
        //opgave 5
        static string PrimeNumbers(int MaxNum = 30)
        {
            string Primes = "";
            int counter = 0;
            int x = 1;
            for (int i = 2; i <= MaxNum; i++)
            {
                while (x <= i)
                {
                    if (i % x == 0)
                    {
                        counter++;
                    }
                    x++;
                }
                x = 1;
                if (counter < 3)
                {
                    Primes += i.ToString() + ", ";
                }
                counter = 0;
            }
            return Primes;
        }


        //opgave 6
        static string ExtractString(string Word = "##abc##def")
        {
            char[] letters = Word.ToCharArray();
            int splitter = 0;
            int adder = 0;
            Word = "";
            string WordHolder = "";
            foreach (char c in letters)
            {
                switch (adder)
                {
                    case 0:
                        if (c.ToString() == "#")
                        {
                            splitter++;
                            if (splitter == 2)
                            {
                                adder = 1;
                            }
                        }
                        break;
                    case 1:
                        if (c.ToString() != "#")
                        {
                            WordHolder += c.ToString();
                        }
                        else
                        {
                            splitter--;
                            if (splitter == 0)
                            {
                                adder = 0;
                                Word += WordHolder;
                            }
                        }
                        break;
                }
            }
            return Word;
        }

        //opgave 7
        static string FullLetters(string FirstLeter = "o", string LastLetter = "r")
        {
            string Sequence = "";
            List<string> L = new List<string>();
            L = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "æ", "ø", "å"] ; 
            for (int i = L.IndexOf(FirstLeter); i <= L.IndexOf(LastLetter); i++)
            {
                Sequence += L[i];
            }
            return Sequence;
        }

        //Opgave 8
        static string SumAndAvg(int min = 1, int max = 10)
        {
            int sum = 0;
            decimal avg;
            for (int i = min;  i <= max; i++) { 
                sum += i;
            }
            avg = sum / (max - min);
            return "Sum: " + sum.ToString() + "\n" + "Average: " + avg.ToString();
        }

        //Opgave 9 //▲
        static string Pyramid(int lag = 9 * 2, string tegn = "▲")
        {
            int x = lag;
            string py = "";
            for (int i = 1; i < lag ; i++) 
            { 

                if (i % 2 >= 1) 
                {
                    for (int ii = x / (2); ii > 0; ii--)
                    {
                        py +=" ";

                    }
                    for (int iii = i; iii > 0; iii--)
                    {
                        py += tegn;
                    }
                    py += "\n";
                }
             x--;
            }
            return py;
        }

        //Opgave 10
        static int PowerOf(int FirstNum = 5, int LastNum = 5)
        {
            return Convert.ToInt32(Math.Pow(FirstNum, LastNum));
        }
    }
}
