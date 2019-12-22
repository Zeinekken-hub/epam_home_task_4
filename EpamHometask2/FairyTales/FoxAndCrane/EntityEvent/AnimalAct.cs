using System;
using static EpamHometask2.PhraseAct;

namespace EpamHometask2
{
    class AnimalAct
    {
        public AnimalAct(IFoodTester owner, IFoodTester guest, Dish makedDish)
        {
            this.Owner = owner;
            this.Guest = guest;
            this.Dish = makedDish;
        }
        //событие
        public event LoggerHandler Logger;
        private IFoodTester Owner { get; }
        private IFoodTester Guest { get; }
        private Dish Dish { get; }

        protected void ExecuteLogger() => Logger?.Invoke(new object(), new ActArgs());

        protected void MakeDishAct(int actNum)
        {
            //
            Logger = null;
            Logger += (t, e) => Message.SendEvent($"{Dish.ToString()}");
            //
            //добавление к рейтингу блюда дружелюбие хозяина
            Dish.GuestRate += Owner.Friendliness;
            Logger += (t, e) => Message.SendEvent($"{Guest.Name} добавил дружелюбие хозяина [{Owner.Friendliness}] к оценке блюда");
            //проверка на лицемерие хозяина
            if (TryFindHypocriteAspects(Owner))
            {
                Logger += (t, e) => Message.SendEvent($"{Guest.Name} что-то подозреват и отнимает от рейтинга блюда 10");
                Dish.GuestRate -= 10;
            }
            //проверка на удовлетворение едой гостя
            if (Dish.GuestRate >= 50)
                Guest.MealSatisfactionLikeGuest = true;
            else
                Guest.MealSatisfactionLikeGuest = false;
            //проверка на удовлетворение едой хозяина, то есть понравилась ли самому хозяину своя еда
            if (Dish.OwnerRate >= 50)
                Owner.MealSatisfactionLikeOwner = true;
            else
                Owner.MealSatisfactionLikeOwner = false;

            Message.Send($"{UniversalDishAct(Owner.Name, Guest.Name, Dish.Dishes.Name, Dish.Food.Name, actNum)}");
        }

        //Составление ответа, основываясь на поданных блюдах
        protected void EatingAct()
        {
            Logger = null;
            int localActNumGuest;
            int localActNumOwner;
            if (Guest.MealSatisfactionLikeGuest)
            {
                if (Guest is Fox)
                {
                    localActNumGuest = 1;
                    Logger += (t, e) => Message.SendEvent($"Лису понравилось блюдо");
                }
                else
                {
                    localActNumGuest = 2;
                    Logger += (t, e) => Message.SendEvent($"Журавлю понравилось блюдо");
                }
            }
            else
            {
                if (Guest is Fox)
                {
                    localActNumGuest = 3;
                    Logger += (t, e) => Message.SendEvent($"Лису не понравилось блюдо");
                }
                else
                {
                    localActNumGuest = 4;
                    Logger += (t, e) => Message.SendEvent($"Журавлю не понравилось блюдо");
                }
            }
            if (!Owner.MealSatisfactionLikeOwner)
            {
                localActNumOwner = 5;
                Logger += (t, e) => Message.SendEvent($"{Owner.Name} не понимает, зачем он приготовил такое блюдо");
            }
            else
            {
                localActNumOwner = 6;
                Logger += (t, e) => Message.SendEvent($"{Owner.Name} наслаждается");
            }

            Message.Send($"{UniversalEatingAct(Owner.Name, Guest.Name, Dish.Dishes.Name, Dish.Food.Name, localActNumOwner)}"
                           + $"\n{UniversalEatingAct(Owner.Name, Guest.Name, Dish.Dishes.Name, Dish.Food.Name, localActNumGuest)}");
        }

        //Определение конца сказки
        protected void FinalAct(IFoodTester Fox, IFoodTester Crane)
        {
            Logger = null;
            if (Fox.MealSatisfactionLikeGuest && Crane.MealSatisfactionLikeGuest)
            {
                Logger += (x, e) => Message.SendEvent("Хорошая концовка");
                Message.Send(GoodEnding);
            }
            else if (Fox.MealSatisfactionLikeGuest && !Crane.MealSatisfactionLikeGuest)
            {
                Logger += (x, e) => Message.SendEvent("Плохая концовка для Журавля");
                Message.Send(BadCraneEnding);
            }
            else if (!Fox.MealSatisfactionLikeGuest && Crane.MealSatisfactionLikeGuest)
            {
                Logger += (x, e) => Message.SendEvent("Плохая концовка для Лисы");
                Message.Send(BadFoxEnding);
            }
            else
            {
                Logger += (x, e) => Message.SendEvent("Плохая концовка");
                Message.Send(BadEnding);
            }
        }

        //Проверка, что животное лицемер, с шансом 40%
        private static bool TryFindHypocriteAspects(IFoodTester animal)
        {
            if (animal.Hypocrite)
                if (SRandom.Random.Next(0, 100) < 40)
                    return true;
                else return false;
            else
                return false;
        }
    }
}
