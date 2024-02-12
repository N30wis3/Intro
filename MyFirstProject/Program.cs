namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 ints
            Console.WriteLine("Opgave 1 \n" + AddAndMult() + "\n \n");

            //1 int
            Console.WriteLine("Opgave 2 \n" + CelToFeh() + "\n \n");

            //2 dec
            Console.WriteLine("Opgave 3 \n" + ElementaryOp() + "\n \n");

            //2 doub, 1 string
            Console.WriteLine("Opgave 4 \n" + CheckerIfSame() + "\n \n") ;

            //3 ints
            Console.WriteLine("Opgave 5 \n" + ModuloOp() + "\n \n");

            //1 double
            Console.WriteLine("Opgave 6 \n" + Cubed() + "\n \n");

            //2 ints
            Console.WriteLine("Opgave 7 \n" + Swap() + "\n \n");
        }

        // Opgave 1
        static int AddAndMult(int FirstNum = 2, int SecondNum = 4, int LastNum = 5)
        {
            return (FirstNum + SecondNum) * LastNum;
        }

        //Opgave 2
        static decimal CelToFeh(decimal Celsius = 0)
        {
            if (Celsius < Convert.ToDecimal(-271.15)) { return Convert.ToDecimal(null); }
            decimal Fahrenheit = (Celsius * Convert.ToDecimal(1.8)) + 32;
            return Fahrenheit;
        }

        //Opgave 3
        static String ElementaryOp(decimal FirstNum = 3, decimal SecNum = 8)
        {
            decimal Add = FirstNum + SecNum;
            decimal Sub = FirstNum - SecNum;
            decimal Mult = FirstNum * SecNum;

            try 
            { 
                decimal div = FirstNum / SecNum;
                return Add.ToString() + " | " + Sub.ToString() + " | " + Mult.ToString() + " | " + div.ToString();
            } catch
            {
                return Add.ToString() + " | " + Sub.ToString() + " | " + Mult.ToString();
            }
        }

        //Opgave 4
        static string CheckerIfSame(double FirstNum = 2, double SecNum = 2, string AddOrSub = "Add") 
        { 
            if (AddOrSub == "Add" || AddOrSub == "add")
            {
                if (FirstNum + SecNum == FirstNum * SecNum)
                {
                    return "true: " + FirstNum.ToString() + " + " + SecNum.ToString() + " = " + FirstNum.ToString() + " * " + SecNum.ToString();
                }
                else
                {
                    return "false: " + FirstNum.ToString() + " + " + SecNum.ToString() + " != " + FirstNum.ToString() + " * " + SecNum.ToString();
                }
            }
            else
            {
                try
                {
                    if (FirstNum - SecNum == FirstNum / SecNum)
                    {
                        return "true: " + FirstNum.ToString() + " - " + SecNum.ToString() + " = " + FirstNum.ToString() + " / " + SecNum.ToString();
                    }
                    else
                    {
                        return "false: " + FirstNum.ToString() + " - " + SecNum.ToString() + " != " + FirstNum.ToString() + " / " + SecNum.ToString();
                    }
                } catch { return "Fejl (Måske under division)"; }
            }
        }


        //Opgave 5
        static int ModuloOp(int FirstNum = 8, int SecNum = 5, int LastNum = 2)
        {
            return (FirstNum % SecNum) % LastNum;
        }

        //Opgave 6
        static double Cubed(double Num = 2)
        {
            return Math.Pow(Num, 3);
        }

        //Opgave 7
        static string Swap(int a = 87, int b = 45)
        {
            int c = a; int d = b;
            b = c;
            a = d;
            
            return "Int a var: " + b.ToString() + " Int a er nu: " + a.ToString() + " Int b var: " + a.ToString() + " Int b er nu: " + b.ToString();
        }
    }
}
