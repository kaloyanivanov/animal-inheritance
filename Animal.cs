using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview
{
    public abstract class Animal
    {
        protected abstract int Health { get; set; }
        protected List<Food> Foods { get; set; }




        public void AddEdibleFood(Food food)
        {
            foreach (var foodItem in Foods)
                if (food.GetType() == foodItem.GetType()) return;
            Foods.Add(food);
        }



        public void Feed(Food food)
        {
            foreach (Food tempFood in Foods)
            {
                if (tempFood.GetType() == food.GetType())
                {
                    Health = Health + food.HealthPoints;
                    return;
                }
            }

            Health = Health - food.HealthPoints;

        }

        public abstract void Move( );


        public void ViewHealth()
        {
            Console.WriteLine(Health);
        }
    }
}
