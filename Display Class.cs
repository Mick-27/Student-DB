using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemtn_Question_2_B1
{
    internal class Display_Class
    {
        public string Name;
        public string Surname;
        public string SponName;
        public string DOB;
        public string JDate;
        public string Nat;

        public Display_Class(string name, string surname, string sponName, string dOB, string jDate, string nat)
        {
            Name = name;
            Surname = surname;
            SponName = sponName;
            DOB = dOB;
            JDate = jDate;
            Nat = nat;
        }
    }
}
