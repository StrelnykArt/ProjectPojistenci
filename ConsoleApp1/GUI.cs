using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class GUI
    {

        public static void RunGUI()
        {
            bool guiStat = true;
            while(guiStat == true)
            {

                Console.WriteLine($"Je to GUI");
                Console.WriteLine($"1) Pridat novyho pojistence");
                Console.WriteLine($"2) Save");
                Console.WriteLine($"3) Leave...");
                Console.WriteLine($"\n");

                Console.Write($":");
                int odp = int.MaxValue;
                try
                {
                    odp = Convert.ToInt32(System.Console.ReadLine());
                }catch(Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
                

                switch (odp)
                {
                    //Pridani Pojistence, je potrebno zadat udaje
                    case 1:
                        Console.Write("Jmeno: "); string jmeno = System.Console.ReadLine();
                        Console.Write("Prijmeni: "); string prijmeni = System.Console.ReadLine();
                        Console.Write("Email: "); string email = System.Console.ReadLine();
                        Console.Write("Mobilni cislo: "); string cisloMob = System.Console.ReadLine();
                        try
                        {
                            Lib.Add(new Pojistenec(jmeno, prijmeni, email, cisloMob));
                            Console.WriteLine($"Pridani noveho pojistence...");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}");
                        }
                        
                        break;
                    case 2: Console.WriteLine($"Saving..."); Pojistenec.CompareAndSave(); break;
                    case 3: Console.WriteLine($"Ex..."); guiStat = false; break;
                    default: Console.WriteLine($"Zadejte jine cislo"); break;
                }
                
            }
        }

    }
}
