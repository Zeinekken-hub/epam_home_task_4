using System;
using System.Collections.Generic;
using System.Text;

namespace EpamHometask2
{
    abstract class FairyTaleHandler
    {
        protected List<ActHandler> actHandlers = new List<ActHandler>();
        protected void Execute(ActArgs e)
        {
            if (actHandlers == null) return;
            foreach (ActHandler t in actHandlers)
            {
                Console.ReadKey();
                t?.Invoke(this, e);
            }
        }
        protected void FillActList(List<ActHandler> acts)
        {
            actHandlers = acts;
        }
    }
}
