using System;
namespace EpamHometask2
{
    class AnimalException : Exception
    {
        public Type UnknownType { get; }

        public AnimalException(string message, Type type) : base(message)
        {
            UnknownType = type;
        }
    }
}
