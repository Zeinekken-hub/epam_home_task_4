namespace EpamHometask2
{
    sealed class Fox : FoxAndCraneAnimal
    {
        public Fox() : base()
        {
            Type = AnimalType.Fox;
            Name = "Лис";
        }

        public override DishType GoodDish => DishType.BananaInFlatPlate; 

        public override DishType NormalDish => DishType.VegetableSaladInDeepPlate; 

        public override DishType BadDish => DishType.OkroshkaInJug; 
    }
}
