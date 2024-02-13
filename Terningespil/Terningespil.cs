using System.Diagnostics.Tracing;

namespace Terningespil
{
    internal class Terningespil
    {
        static void Main(string[] args)
        {
            /*
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
                
                
            } */

            //For sjov
            //Console.WriteLine(EnMegetHøj());

        }



        static int TerningeKaster(int Terninger)
        {
            Terning Dice = new Terning();
            Dice.Faces = 6;

            Random Terning = new Random();
            int AntalRul = 0;
            int x = 0;
            bool AllSix = false;

            while (AllSix == false)
            {
                AntalRul++;
                for (int i = 0; i < Terninger; i++) 
                {
                    if (Terning.Next(1, Dice.Faces + 1) == 6)
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


        static string EnMegetHøj()
        {
            int StoreLen = 0;
            Int128 min = 0;
            Int128 max = Int64.MaxValue / 2;
            Random Terning = new Random();
            string Beskrivelse = "";
            int Forsøg = 0;
            int tal = 0;
            for (Int128 i = min; i < max / 2; i++)
            {
                
                Forsøg++;
                if (Terning.Next(1, 7) == 6)
                {
                    if (Forsøg > tal)
                    {
                        tal = Forsøg;
                        Console.WriteLine("Antal forsøg: " + tal + " | i: " + i);
                        
                    }
                 Forsøg = 0;
                }
                if (i == (max - min) / 2)
                {
                    Console.WriteLine("OHHH we're half way there");
                }
                if (i.ToString().Length > StoreLen)
                {
                    StoreLen = i.ToString().Length;
                    Console.WriteLine(i);
                }

            }
            Beskrivelse = "Højest mængde forsøg var: " + tal;
            return Beskrivelse;
        }
    }
}
