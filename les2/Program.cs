using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSLES2
{

    class Enemy
    {
        public int EnemyHealth = 25;
        public int eDamage(int Damage)
        {
            EnemyHealth -= Damage;
            return EnemyHealth;
        }

    }


    class Program
    {
        static void Main(string[] args)
        { 
            Enemy EnemyHealth = new Enemy();
            bool alive = true;
            while (alive)
            {
                EnemyHealth.eDamage(5);

                if (EnemyHealth.EnemyHealth == 0)
                {
                    alive = false;
                    Console.WriteLine("I am dede");
                }
            }
            Console.ReadLine();

        }


    }
}

