using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pojistenec
    {

        private string Jmeno { get; set; }
        private string Prijmeni { get; set; }
        private string Email { get; set; }
        private string CisloMob { get; set; }

        public Pojistenec(string jmeno, string prijmeni, string email, string cisloMob)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Email = email;
            CisloMob = cisloMob;
        }

        public override string ToString()
        {
            return $"{Jmeno};{Prijmeni};{Email};{CisloMob}";
        }

    }
}
