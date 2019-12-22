namespace EpamHometask2
{
    class Dishes
    {
        public string Name { get; set; }
        public DishesType Type { get; set; }
        public Dishes(DishesType type)
        {
            Type = type;
            Name = CustomConverter.ConvertDishesTypeToName(type);
        }

        public Dishes()
        {
        }
    }
}
