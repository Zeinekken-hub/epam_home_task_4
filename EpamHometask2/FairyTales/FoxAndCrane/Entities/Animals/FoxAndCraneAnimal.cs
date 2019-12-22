namespace EpamHometask2
{
    abstract class FoxAndCraneAnimal : Animal, IDishable
    {
        public abstract DishType GoodDish { get; }
        public abstract DishType NormalDish { get; }
        public abstract DishType BadDish { get; }
    }
}
