namespace EpamHometask2
{
    class Food
    {
        public string Name { get; set; }
        public FoodType Type { get; set; }
        
        public Food(string name)
        {
            Name = name;
        }

        public Food(FoodType type)
        {
            Type = type;
            Name = CustomConverter.ConvertFoodTypeToName(type);
        }
        public Food() { }
    }
}
