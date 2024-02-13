namespace Terningespil
{
    internal class Terningespil
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Antal terninger: ");
                try 
                {
                    int AntalTerninger = Convert.ToInt32(Console.ReadLine());
                    if (AntalTerninger < 1) 
                    { 
                        AntalTerninger = 1; 
                    }
                    if (TerningeKaster(AntalTerninger) == -1)
                    {
                        Console.WriteLine("Det tog over " + int.MaxValue + " forsøg\n");
                    }
                    else
                    {
                        Console.WriteLine("Det tog " + TerningeKaster(AntalTerninger) + " forsøg\n");
                    }
                } catch { Console.WriteLine("Fejl! Prøv igen"); }
                
                
            }

        }



        static int TerningeKaster(int Terninger)
        {
            Random Terning = new Random();
            int AntalRul = 0;
            int x = 0;
            bool AllSix = false;

            while (AllSix == false)
            {
                AntalRul++;
                for (int i = 0; i < Terninger; i++) 
                {
                    if (i != Terninger - 1)
                    {
                    }
                    if (Terning.Next(1, 7) == 6)
                    {
                        x++;
                    } else { i = Terninger; }
                }
                if (x == Terninger)
                {
                    AllSix = true;
                }
                else { x = 0; }
                if (AntalRul == int.MaxValue)
                {
                    return -1;
                }
            }
            return AntalRul;
        }
    }
}
