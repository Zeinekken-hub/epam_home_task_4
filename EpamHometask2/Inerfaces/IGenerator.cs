namespace EpamHometask2
{
    interface IGenerator<out T>
    {
        T Generate();
    }
}
