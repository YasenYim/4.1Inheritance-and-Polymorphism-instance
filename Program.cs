using System;

namespace _4_1继承和多态范例
{
    class 豌豆射手
    {
        public virtual void Shoot()
        { Console.WriteLine("豌豆射击"); }
    }

    class 冰豌豆射手: 豌豆射手
    {
        public override void Shoot()
        { Console.WriteLine("冰豌豆射手"); }
    }

    class 双头豌豆射手: 豌豆射手
    {
        public override void Shoot()
        { Console.WriteLine("双向射击"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            豌豆射手 w1 = new 豌豆射手();
            冰豌豆射手 w2 = new 冰豌豆射手();
            双头豌豆射手 w3 = new 双头豌豆射手();

            //w1.Shoot();
            //w2.Shoot();
            //w3.Shoot();

            豌豆射手 w = w1;
            w.Shoot();
            w = w2;
            w.Shoot();
            w = w3;
            w.Shoot();
        }
          
    }
}
