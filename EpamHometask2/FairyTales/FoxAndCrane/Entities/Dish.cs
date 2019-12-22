namespace EpamHometask2
{
    class Dish
    {
        private int ownerRate;
        private int guestRate;
        private Food food;
        private Dishes dishes;
        public Food Food
        {
            get
            {
                try
                {
                    if (food == null)
                        throw new DishException("Отсутствует еда в блюде");
                }
                catch (DishException)
                {
                    Message.SendError("Dish error");
                }
                return food;
            }
            set => food = value;
        }
        public Dishes Dishes
        {
            get
            {

                try
                {
                    if (dishes == null)
                        throw new DishException("Отсутствует посуда");
                }
                catch (DishException)
                {
                    Message.SendError("Dish error");
                }
                return dishes;
            }
            set => dishes = value;
        }
        public int OwnerRate
        {
            get => ownerRate;
            set
            {
                try
                {
                    if (value < 0 || value > 100)
                        throw new RatingException("Рейтинг отрицательный или превышает 100", value);
                    else
                        ownerRate = value;
                }
                catch (RatingException)
                {
                    Message.SendError("Rating error");
                }
            }
        }
        public int GuestRate
        {
            get => guestRate;
            set
            {
                try
                {
                    if (value < 0 || value > 100)
                        throw new RatingException("Рейтинг отрицательный или превышает 100", value);
                    else
                        guestRate = value;
                }
                catch (RatingException)
                {
                    Message.SendError("Rating error");
                }
            }
        }

        public Dish MakeRate(IDishable owner, IDishable guest)
        {
            int dishNum = (int)Food.Type + (int)Dishes.Type;
            if (dishNum == (int)owner.GoodDish && dishNum == (int)guest.GoodDish)
            {
                OwnerRate = 80;
                GuestRate = 80;
            }
            else if (dishNum == (int)owner.NormalDish)
            {
                GuestRate = 50;
                OwnerRate = 50;
            }
            else if (dishNum == (int)guest.NormalDish)
            {
                OwnerRate = 50;
                GuestRate = 50;
            }
            else if (dishNum == (int)guest.BadDish)
            {
                OwnerRate = 100;
                GuestRate = 0;
            }
            else if (dishNum == (int)owner.BadDish)
            {
                GuestRate = 100;
                OwnerRate = 0;
            }
            else
            {
                OwnerRate = 15;
                GuestRate = 15;
            }
            return this;
        }

        public override string ToString()
        {
            return $"Блюдо: Еда: {Food.Name}, Посуда: {Dishes.Name}, Рейтинг хозяина: {OwnerRate}, Рейтинг гостя: {GuestRate}";
        }
    }
}
