namespace EpamHometask2
{
    interface IFoodTester : ISoulable
    {
        bool MealSatisfactionLikeGuest { get; set; }
        bool MealSatisfactionLikeOwner { get; set; }
    }
}
