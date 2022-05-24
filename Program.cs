using interview;


var rabbit = new Rabbit();
var hedgehog = new Hedgehog();
List<Food> foods = new List<Food>();
foods.Add(new Carrot());
foods.Add(new Wheat());
foods.Add(new Apple());
foreach (var food in foods)
{
    rabbit.Feed(food);
    hedgehog.Feed(food);

}
rabbit.ViewHealth();
hedgehog.ViewHealth();

