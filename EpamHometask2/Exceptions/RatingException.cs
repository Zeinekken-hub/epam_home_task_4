namespace EpamHometask2
{
    class RatingException : DishException
    {
        public int RateValue { get; }
        public RatingException(string message, int value) : base(message)
        {
            RateValue = value;
        }
    }
}
