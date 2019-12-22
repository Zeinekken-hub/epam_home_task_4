using System.Collections.Generic;
using static EpamHometask2.PhraseDialogue;
using static EpamHometask2.PhraseAct;

namespace EpamHometask2
{

    sealed class FoxAndCrane : FairyTale
    {
        const int dishesCount = 2;
        public FoxAndCrane()
        {
            Fox = new AnimalGenerator<Fox>().Generate();
            Crane = new AnimalGenerator<Crane>().Generate();
            Dishes = new DishGenerator<Dish>().Generate(dishesCount);
            CreateTale();
        }
        public FoxAndCrane(string name) : base(name) { }
        private Fox Fox { get; set; }
        private Crane Crane { get; set; }
        private List<Dish> Dishes { get; set; } = new List<Dish>();
        private void CreateTale()
        {
            AnimalEvent aEvent = new AnimalEvent(Fox, Crane, Dishes[0].MakeRate(Fox, Crane));
            List<ActHandler> acts = new List<ActHandler>
            {
                (x, e) => new Act(StartAct).Display(),
                (x, e) => aEvent.MakeDish(x, new ActArgs(1)),
                (x, e) => new Act(FoxFirstPhraseFirstAct).Display(),
                (x, e) => aEvent.Eating(x, e),
                (x, e) => new Act(FoxSecondPhraseFirstAct).Display(),
                (x, e) => new Act(CraneFirstPhraseFirstAct).Display()
            };
            //2act
            AnimalEvent aEvent2 = new AnimalEvent(Crane, Fox, Dishes[1].MakeRate(Crane, Fox));
            acts.Add((x, e) => aEvent2.MakeDish(x, new ActArgs(2)));
            acts.Add((x, e) => new Act(CraneFirstPhraseSecondAct).Display());
            acts.Add((x, e) => aEvent2.Eating(x, e));
            acts.Add((x, e) => new Act(CraneSecondPhraseSecondAct).Display());
            acts.Add((x, e) => aEvent.Final(x, new ActArgs(Fox, Crane)));

            FillActList(acts);
        }
    }
}
