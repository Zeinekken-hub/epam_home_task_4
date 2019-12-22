using System;
using System.Collections.Generic;
using System.Text;

namespace EpamHometask2
{
    abstract class FairyTale : FairyTaleHandler, IFairyTale
    {
        public FairyTale() { }
        public FairyTale(string name) => Name = name;
        public string Name { get; set; }
        public virtual void Start()
        {
            Execute(new ActArgs());
        }
    }
}
