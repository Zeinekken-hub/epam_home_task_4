namespace EpamHometask2
{
    static class CustomConverter
    {
        public static string ConvertFoodTypeToName(FoodType type) =>
            type switch
            {
                FoodType.Banana => "Банан",
                FoodType.Okroshka => "Окрошка",
                FoodType.Semolina => "Манная каша",
                FoodType.VegetableSalad => "Овощной салат",
                _ => null
            };
        public static string ConvertDishesTypeToName(DishesType type) =>
            type switch
            {
                DishesType.DeepPlate => "глубокая тарелка",
                DishesType.FlatPlate => "плоская тарелка",
                DishesType.Jug => "кувшин",
                _ => null
            };
    }
}
