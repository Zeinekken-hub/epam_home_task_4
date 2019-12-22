using System;

namespace EpamHometask2
{
    abstract class Animal : IFoodTester
    {
        private int friendliness;
        public bool MealSatisfactionLikeGuest { get; set; }
        public string Name { get; set; }
        public bool Hypocrite { get; set; }
        public bool MealSatisfactionLikeOwner { get; set; }
        public AnimalType Type { get; set; }
        public int Friendliness
        {
            get
            {
                return friendliness;
            }
            set
            {
                try
                {
                    if (value < 0 || value > 30)
                        throw new FriendException("Значение дружбы должно быть от 0 до 30 включительно");
                    else
                        friendliness = value;
                }
                catch (FriendException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public override string ToString()
        {
            return $"{Name}\nДружелюбие: {friendliness}, Лицемер: {Hypocrite}\n";
        }
    }
}
