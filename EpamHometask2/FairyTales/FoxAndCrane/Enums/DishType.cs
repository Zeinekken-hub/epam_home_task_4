namespace EpamHometask2
{
    enum DishType
    {
        VegetableSaladInDeepPlate = DishesType.DeepPlate + FoodType.VegetableSalad,  
        OkroshkaInDeepPlate = DishesType.DeepPlate + FoodType.Okroshka, 
        OkroshkaInJug = DishesType.Jug + FoodType.Okroshka, 
        SemolinaInFlatPlate = DishesType.FlatPlate + FoodType.Semolina,  
        BananaInFlatPlate = DishesType.FlatPlate + FoodType.Banana
    }

}
