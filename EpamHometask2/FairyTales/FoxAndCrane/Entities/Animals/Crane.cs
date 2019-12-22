namespace EpamHometask2
{

    sealed class Crane : FoxAndCraneAnimal
    {
        public Crane() : base()
        {
            Type = AnimalType.Crane;
            Name = "Журавль";
        }

        public override DishType GoodDish => DishType.BananaInFlatPlate; 
        public override DishType NormalDish => DishType.OkroshkaInDeepPlate; 
        public override DishType BadDish => DishType.SemolinaInFlatPlate; 
    }
}
