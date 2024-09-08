using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobAndJoeDudes
{
    internal class Guy
    {
        public string Name;
        public int Cash;


        public void WriteMyInfo()
        {
            Console.WriteLine($"{Name} has {Cash} bucks.");
        }

        public int GiveCash(int amount)
        {
            return 0;
        }

        public int Receive(int amount)
        {
            return 0;
        }
    }
}
