using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Account
    {
        private string name;
       
        private string surname;
        private int cash;
        public string Name { get { return name; } set { name = value; } }
       
        public string Surname { get { return surname; } set { surname = value; } }
        public int Cash 
        { 
            get
            { 
                return cash;
            } 
            set 
            {
                if (cash + value <= 0)
                {
                    Console.WriteLine("У вас нет такой суммы на карте");

                }
                else
                {
                    cash += value;
                }

            } 
        }
        public int deposit(int add)
        {
            cash += add;
            return cash;
        }
        public int withdraw(int minus)
        {
            if (cash - minus <= 0)
            {
                Console.WriteLine("У вас нет такой суммы на карте");
                return cash;
            }
            else
            {
                cash -= minus;
                return cash;
            }
                
        }
            
        public void CashInfo()
        {
            Console.WriteLine(cash);
        }
    }
}
