using System;
using System.Collections.Generic;
using System.Linq;

namespace EpamHometask2
{
    class DishGenerator<T> : IGenerator<T> where T : Dish, new()
    {
        public List<Dish> Generate(int dishNum)
        {
            var lst = new List<Dish>();
            for (int i = 0; i < dishNum; i++)
            {
                var tuple = CustomRandom();
                T dish = new T()
                {
                    Dishes = new Dishes((DishesType)tuple.Item1),
                    Food = new Food((FoodType)tuple.Item2)
                };
                lst.Add(dish);
            }
            return lst;
        }
        public T Generate()
        {
            var tuple = CustomRandom();
            T dish = new T()
            {
                Dishes = new Dishes((DishesType)tuple.Item1),
                Food = new Food((FoodType)tuple.Item2)
            };
            //Попытка поставить null с шансом 5%
            dish.Dishes = (Dishes)Anomaly.TrySet(dish.Dishes);
            dish.Food = (Food)Anomaly.TrySet(dish.Food);
            //
            return dish;
        }

        private bool IsPowerOfTwo(int val)
        {
            if (val == 1) return true;
            return val != 0 && (val & (val - 1)) == 0;
        }
        // Рандомит кортеж (номер посуды из DishesType, номер еды из FoodType)
        private (int, int) CustomRandom()
        {
            var maxDishes = (int)Enum.GetValues(typeof(DishesType)).Cast<DishesType>().Last();
            var maxFood = (int)Enum.GetValues(typeof(FoodType)).Cast<FoodType>().Last();
            List<int> randomDishes = new List<int>();
            List<int> randomFood = new List<int>();

            for (int i = 1; i <= maxDishes; i++)
                if (IsPowerOfTwo(i))
                    randomDishes.Add(i);
            for (int i = 1; i <= maxFood; i++)
                if (IsPowerOfTwo(i))
                    randomFood.Add(i);

            return (randomDishes[SRandom.Random.Next(0, randomDishes.Count)], randomFood[SRandom.Random.Next(0, randomDishes.Count)]);
        }
    }
}
