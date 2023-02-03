using System;

namespace _0901_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit u1 = new Unit("Воин", 10, 100);
            Unit u2 = new Unit("Маг", 20, 60);

            while (true) {
                if (u1.Attack(u2) == false || u2.Attack(u1) == false) break;
                
                    u1.Attack(u2);
                    u2.Attack(u1);
              
            }

            u1.Display();
            u2.Display();
        }
    }
}
