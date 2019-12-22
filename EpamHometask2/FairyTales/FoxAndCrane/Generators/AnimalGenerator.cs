namespace EpamHometask2
{
    class AnimalGenerator<T> : IGenerator<T> where T : Animal, new()
    {
        public T Generate()
        {
            T animal = new T
            {
                Friendliness = SRandom.Random.Next(0, 30),
                Hypocrite = SRandom.Random.Next(0, 100) < SRandom.Random.Next(0, 100)
            };
            return animal;
        }
    }
}
