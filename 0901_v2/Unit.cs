using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0901_v2
{
    class Unit
    {
        private string name;
        private int damage;
        private int health;
        public Unit(string n, int d, int h)
        {
            name = n;
            damage = d;
            health = h;
        }
        public bool Attack(Unit enemy)
        {
            if (enemy.health <= 0 || health <= 0)
            {

               // Console.WriteLine("Враг умер, прекратите это безумие");
                return false;
            }
            else
            {
                System.Console.Write(name + " атакует врага " + enemy.name);
                System.Console.Write(" и наносит урон " + damage + " урона\n");

                enemy.health -= damage;
                return true;

            }
        }
        public void Display()
        {
            Console.WriteLine("___________");
            Console.WriteLine("Класс: " + name);
            Console.WriteLine("Урон: " + damage);
            Console.WriteLine("Здоровье: " + health);
            Console.WriteLine("___________");
        }

        
    }
}
