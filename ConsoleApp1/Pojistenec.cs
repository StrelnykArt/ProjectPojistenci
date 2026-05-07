using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pojistenec
    {

        private string Jmeno { get; set; }
        private string Prijmeni { get; set; }
        private string Email {  get;  set; }
        private string CisloMob { get; set; }

        public Pojistenec(string jmeno, string prijmeni, string email, string cisloMob)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Email = email;
            CisloMob = cisloMob;
        }

        public static void CompareAndSave()
        {
            string radek = "";
            string[] pojistenec;
            List<Pojistenec> listNewPojistenci = Lib.GetList();

            using (StreamReader sr = new StreamReader("./pojistenci.txt"))
            {
                while ((radek = sr.ReadLine()) != null)
                {
                    pojistenec = radek.Split(';');
                    string mail = pojistenec[2];
                   
                    for(int a = 0; a < listNewPojistenci.Count; a++)
                    {
                        string meow = listNewPojistenci.ElementAt(a).Email;
                        if (meow == mail)
                        {
                            listNewPojistenci.RemoveAt(a);
                        }
                        
                    }

                }
            }

            using (StreamWriter sw = new StreamWriter("./pojistenci.txt", true))
            {

                for (int a = 0; a < listNewPojistenci.Count; a++)
                {
                    sw.WriteLine($"{listNewPojistenci[a]}");
                }
            }

        }

        public override string ToString()
        {
            return $"{Jmeno};{Prijmeni};{Email};{CisloMob}";
        }

    }
}
