namespace EpamHometask2
{
    interface IDishable
    {
        DishType GoodDish { get; }
        DishType NormalDish { get; }
        DishType BadDish { get; }
    }
}
