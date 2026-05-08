using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Lib
    {

        static List<Pojistenec> currentPojistenciForLoad = new List<Pojistenec>();

        public static void Add(Pojistenec newP)
        {
            try
            {


                currentPojistenciForLoad.Add(newP);


            }catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        public static void GetAllNewPojistenci()
        {
            if(currentPojistenciForLoad.Count > 0)
            {
                Console.WriteLine($"Zaznam:");
                foreach (Pojistenec poj in currentPojistenciForLoad)
                {
                    Console.WriteLine($"{poj}");
                }
                Console.WriteLine($"\n");
            }
            else
            {
                Console.WriteLine($"Zaznam pridavanych pojistencu je prazdny...\n");
            }
            
        }

        public static void GetPojistenci()
        {
            using (StreamReader sr = new StreamReader("./pojistenci.txt"))
            {
                string row = "";
                Console.WriteLine($"Cely zaznam Pojistencu:\n_______________________");
                while ((row = sr.ReadLine()) != null)
                {
                    Console.WriteLine($"{row}");
                }
                Console.WriteLine($"\n");
            }
        }

        public static List<Pojistenec> GetList()
        {
            return currentPojistenciForLoad;
        }

    }
}
