using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSLES2
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy eHealth = new Enemy();
            bool alive = true;
            while (alive)
            {
               
                if (eHealth.Health == 0)
                {
                    alive = false;
                   
                }
            }
           
            
                eHealth.eHealth2Change();
                Console.WriteLine("I am dede");
            //boy wth why do you refuse to console.writeline youre dead aintchu???
        }
    }
    class Enemy
    {
        public int Health = 25;
        public int eDamage(int eHealth2, int Damage)
        {
            eHealth2 -= Damage;
            return eHealth2;
        }
        public int eHealth2Change()
        {
            Health = eDamage(Health, 5);
            return Health;
        }
    }

}
