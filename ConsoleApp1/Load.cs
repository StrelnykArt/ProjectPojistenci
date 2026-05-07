using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Load
    {

        public static void Export()
        {
            using(StreamWriter sw = new StreamWriter("./pojistenci.txt", true))
            {
                List<Pojistenec> listToLoad = Lib.GetList();
                for(int a = 0; a < listToLoad.Count; a++)
                {
                    sw.WriteLine($"{listToLoad[a]}");
                }
            }
        }

        public static void Nuch(List<Pojistenec> listForNuch)
        {
            
        }

    }
}
