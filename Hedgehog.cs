using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview
{
    public class Hedgehog : Animal
    {
        public Hedgehog()
        {
            Health = 50;
            Foods = new List<Food>();
            Foods.Add(new Apple());

        }

        protected override int Health { get; set; }

        public override void Move()
        {
            Console.WriteLine("I am a hedgehog and I walk.");
        }
    }
}
