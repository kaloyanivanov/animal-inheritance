using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview
{
    public class Rabbit:Animal
    {


        public Rabbit()
        {
            Health = 100;
            Foods =new List<Food> ();
            Foods.Add(new Wheat());
            Foods.Add(new Carrot());

        }

        protected override int Health { set; get; }

        public override void Move() 
        {
            Console.WriteLine("I am a rabbit and I jump.");
        }

    }
}
