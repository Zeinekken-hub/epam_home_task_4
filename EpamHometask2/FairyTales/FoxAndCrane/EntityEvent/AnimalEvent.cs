using System;
using System.Collections.Generic;
using System.Text;

namespace EpamHometask2
{
    class AnimalEvent : AnimalAct
    {
        public AnimalEvent(IFoodTester o, IFoodTester g, Dish d) : base(o, g, d) { }

        public void MakeDish(object sender, ActArgs e)
        {
            MakeDishAct(e.ActNum);
            ExecuteLogger();
        }

        public void Eating(object sender, ActArgs e)
        {
            EatingAct();
            ExecuteLogger();
        }

        public void Final(object sender, ActArgs e)
        {
            FinalAct(e.Fox, e.Crane);
            ExecuteLogger();
        }
    }
}
