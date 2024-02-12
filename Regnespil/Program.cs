namespace Regnespil
{
    internal class Program
    {
         static void Main(string[] args)
        {
            bool GameOn = true;
            string WIP = " ~~Work in progress~~\n";
            string InvInp = " ~~Invalid input~~ \n \n";

            int sværhedsgrad = 1;
            bool NegativeTal = false;

            while (GameOn)
            {
                int Forsøg = 3;
                Console.WriteLine("Vælg disciplin: \n" + "(+) addition \n" + "(-) subtraktion \n" + "(*) multiplikation \n" + "(/) divition \n" + "skriv indstillinger (ind) for at ændre sværhedsgrad eller quit for at stoppe spillet: \n");

                string DisValg = Console.ReadLine();
                Console.WriteLine("\n");
                switch (DisValg)
                {
                    case "Quit" or "quit":
                        GameOn = false;
                        break;

                    case "indstillinger" or "Indstillinger" or "ind" or "Ind" or "i" or "I" or "In" or "in":
                        Indstillinger(ref sværhedsgrad, ref NegativeTal);
                        break;

                    case "+" or "addition" or "Addition":
                        Addition(ref sværhedsgrad, ref NegativeTal, ref Forsøg);
                        break;

                    case "-" or "subtraktion" or "Subtraktion":
                        Subtraktion(ref sværhedsgrad, ref NegativeTal, ref Forsøg);
                        break;

                    case "*" or "multiplikation" or "Multiplikation":
                        Multiplikation(ref sværhedsgrad, ref NegativeTal, ref Forsøg);
                        break;

                    case "/" or "divition" or "Divition":
                        Divition(ref sværhedsgrad, ref NegativeTal, ref Forsøg);
                        break;

                    default:
                        Console.WriteLine(InvInp);
                        break;
                }
            }
        }
         static void Indstillinger(ref int sværhedsgrad, ref bool NegativeTal)
        {
            bool SettingsOpen = true;
            while (SettingsOpen)
            {
                Console.WriteLine("\n\n\nSværhedsgrad er: " + sværhedsgrad + " | Inkluder negavtivetal: " + NegativeTal + "\n\n" + "Valgmuligheder: \n" + "(1) Sværhedsgrad\n" + "(2) Negative tal\n" + "(3) Menu\n");
                string IndValg = Console.ReadLine();
                switch (IndValg)
                { 
                    //Sværhedsgrad begynd | v
                    case "1" or "Sværhedsgrad" or "sværhedsgrad":
                        Console.WriteLine("Sværhedsgrader: \n" + "(1) Let\n" + "(2) Medium\n" + "(3) Svær\n" + "(4) Udfordrende");
                        IndValg = Console.ReadLine();
                        //Valg af sværhedsgrader start | v
                        switch (IndValg)
                        {
                            case "1" or "Let" or "let":
                                sværhedsgrad = 1;
                                break;

                            case "2" or "Medium" or "medium":
                                sværhedsgrad = 2;
                                break;

                            case "3" or "Svær" or "svær":
                                sværhedsgrad = 3;
                                break;

                            case "4" or "Udfordrende" or "udfordrende":
                                sværhedsgrad = 4;
                                break;
                            default:
                                Console.WriteLine("Ukendt Input\n");
                                break;
                        //Valg af sværhedsgrader start | ^
                        }

                        Console.WriteLine("\n");
                        break;
                    //Sværhedsgrad slut | ^

                    //Negative tal start | v
                    case "2" or "Negative tal" or "negative tal":
                        Console.WriteLine("Negative tal: \n" + "(1) Til\n" + "(2) Fra\n");
                        IndValg = Console.ReadLine();
                        //Valg omkring negative tal start | v
                        switch (IndValg)
                        {
                            case "1" or "Til" or "til":
                                NegativeTal = true;
                                break;

                            case "2" or "Fra" or "fra":
                                NegativeTal = false;
                                break;
                            default:
                                Console.WriteLine("Ukendt Input\n");
                                break;
                        }
                        //Valg omkring negative tal start | ^
                        Console.WriteLine("\n");
                        break;
                    //Negative tal slut | ^

                    case "3" or "Menu" or "menu":
                        SettingsOpen = false;
                        Console.WriteLine("\n\n\n");
                        break;

                    default:
                        Console.WriteLine(" ~~Invalid input~~ \n \n");
                        break;
                }
            }
       
        }



        static double RandomNumber(ref int sværhedsgrad, ref bool NegativeTal)
        {
            Random RNum = new Random();

            switch (sværhedsgrad)
            {
                case 1:
                    switch (NegativeTal)
                    {
                        case false:
                            return RNum.Next(1, 11);
                        case true:
                            return RNum.Next(-10, 11);
                    }
                    
                case 2:
                    switch (NegativeTal)
                    {
                        case false:
                            return RNum.Next(1, 101);
                        case true:
                            return RNum.Next(-100, 101);
                    }
                    
                case 3:
                    switch (NegativeTal)
                    {
                        case false:
                            return RNum.Next(1, 1001);
                        case true:
                            return RNum.Next(-1000, 1001);
                    }
                    
                case 4:
                    switch (NegativeTal)
                    {
                        case false:
                            return RNum.Next(1, 10000);
                        case true:
                            return RNum.Next(-9999, 10000);
                    }
                default:
                    return RNum.Next(int.MinValue, int.MaxValue);
            }
        }

        static string Liv(ref int Forsøg)
        {
            switch (Forsøg)
            {                    
                case 2:
                    return "[X] [X] [ ]\n" + "2 liv";
                case 1:
                    return "[X] [ ] [ ]\n" + "1 liv";
                case 0:
                    return "[ ] [ ] [ ]\n" + "0 liv";
                default:
                    return "[X] [X] [X]\n" + "3 liv";
            }
        }

        static void Addition(ref int sværhedsgrad, ref bool NegativeTal, ref int Forsøg)
        {
            double sum;
            double FirstNum;
            double SecondNum;
            double svar;
            Console.WriteLine(Liv(ref Forsøg));
            for (int i = 1; i < 11;)
            {
                FirstNum = RandomNumber(ref sværhedsgrad, ref NegativeTal);
                SecondNum = RandomNumber(ref sværhedsgrad, ref NegativeTal);
                sum = FirstNum + SecondNum;
                Console.WriteLine(i + ". " + FirstNum + " + " + SecondNum + " = ");
                try
                {
                    svar = Convert.ToDouble(Console.ReadLine());
                }
                catch { svar = 0; }

                if (svar == sum)
                {
                    Console.WriteLine("Rigtig\n");
                    i++;
                }
                else 
                { 
                    Console.WriteLine("Forkert\n" + "svar var: " + sum + "\n");
                    Forsøg--;
                    Console.WriteLine(Liv(ref Forsøg));
                    if (Forsøg == 0)
                    {
                        Console.WriteLine("\n");
                        break;
                    }

                }
            }
        }

        static void Subtraktion(ref int sværhedsgrad, ref bool NegativeTal, ref int Forsøg)
        {
            double sum;
            double FirstNum;
            double SecondNum;
            double svar;
            Console.WriteLine(Liv(ref Forsøg));
            for (int i = 1; i < 11;)
            {
                FirstNum = RandomNumber(ref sværhedsgrad, ref NegativeTal);
                SecondNum = RandomNumber(ref sværhedsgrad, ref NegativeTal);
                if ( NegativeTal == false && FirstNum < SecondNum)
                {
                    sum = SecondNum - FirstNum;
                    Console.WriteLine(i + ". " + SecondNum + " - " + FirstNum + " = ");
                } else 
                { 
                    sum = FirstNum - SecondNum;
                    Console.WriteLine(i + ". " + FirstNum + " - " + SecondNum + " = ");
                }
                try
                {
                    svar = Convert.ToDouble(Console.ReadLine());
                }
                catch { svar = 0; }

                if (svar == sum)
                {
                    Console.WriteLine("Rigtig\n");
                    i++;
                }
                else 
                { 
                    Console.WriteLine("Forkert\n" + "svar var: " + sum + "\n");
                    Forsøg--;
                    Console.WriteLine(Liv(ref Forsøg));
                    if (Forsøg == 0)
                    {
                        Console.WriteLine("\n");
                        break;
                    }
                }
            }
        }

        static void Multiplikation(ref int sværhedsgrad, ref bool NegativeTal, ref int Forsøg)
        {
            double sum;
            double FirstNum;
            double SecondNum;
            double svar;
            Console.WriteLine(Liv(ref Forsøg));
            for (int i = 0; i < 10; i++)
            {
                FirstNum = RandomNumber(ref sværhedsgrad, ref NegativeTal);
                SecondNum = RandomNumber(ref sværhedsgrad, ref NegativeTal);
                sum = FirstNum * SecondNum;
                Console.WriteLine(FirstNum + " * " + SecondNum + " = ");
                try
                {
                    svar = Convert.ToDouble(Console.ReadLine());
                }
                catch { svar = 0; }

                if (svar == sum)
                {
                    Console.WriteLine("Rigtig\n");
                }
                else 
                { 
                    Console.WriteLine("Forkert\n" + "svar var: " + sum + "\n");
                    Forsøg--;
                    Console.WriteLine(Liv(ref Forsøg));
                    if (Forsøg == 0)
                    {
                        Console.WriteLine("\n");
                        break;
                    }
                }
            }
        }

        static void Divition(ref int sværhedsgrad, ref bool NegativeTal, ref int Forsøg)
        {
            double sum;
            double FirstNum;
            double SecondNum;
            double svar;
            Console.WriteLine(Liv(ref Forsøg));
            for (int i = 0; i < 10; i++)
            {
                FirstNum = RandomNumber(ref sværhedsgrad, ref NegativeTal);
                SecondNum = RandomNumber(ref sværhedsgrad, ref NegativeTal);
                if (FirstNum == 0)
                {
                    FirstNum++;
                }
                else if (SecondNum == 0)
                {
                    SecondNum++;
                }
                sum = FirstNum / SecondNum;
                Console.WriteLine(FirstNum + " / " + SecondNum + " = ");
                try
                {
                    svar = Convert.ToDouble(Console.ReadLine());
                }
                catch { svar = 0; }

                if (svar == sum)
                {
                    Console.WriteLine("Rigtig\n");
                }
                else 
                { 
                    Console.WriteLine("Forkert\n" + "svar var: " + sum + "\n");
                    Forsøg--;
                    Console.WriteLine(Liv(ref Forsøg));
                    if (Forsøg == 0)
                    {
                        Console.WriteLine("\n");
                        break;
                    }
                }
            }
        }
    }
}