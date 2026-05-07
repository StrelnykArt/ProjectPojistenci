using System;
using System.Collections.Generic;
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

        public static List<Pojistenec> GetList()
        {
            return currentPojistenciForLoad;
        }

    }
}
