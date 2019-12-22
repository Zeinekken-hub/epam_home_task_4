namespace EpamHometask2
{
    static class Anomaly
    {
        public static object TrySet(object obj)
        {
            if (SRandom.Random.Next(0, 100) < 5)
                return null;
            return obj;
        }
    }
}
