using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Cash
{
    internal class Guy
    {

            // static int BankCash = 100;  // Variable accesible a Joe y Bob
            public string Name = "";
            protected string Surname = "";
            public int Cash = 0;

        public Guy(string Name, int Cash)
        {
            this.Name = Name;
            this.Cash = Cash;
        }

        public string getName()
        {
            return Name;
        }

        public int getCash()
        {
            return this.Cash;
        }
        public void setCash(int NewCash) {
        this.Cash= NewCash;
        }
    }
}
