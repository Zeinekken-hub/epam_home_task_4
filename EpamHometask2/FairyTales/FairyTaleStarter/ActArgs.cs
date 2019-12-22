using System;

namespace EpamHometask2
{
    class ActArgs : EventArgs
    {
        public Fox Fox;
        public Crane Crane;
        public int ActNum { get; set; }
        public ActArgs(int t) => ActNum = t;
        public ActArgs() { }
        public ActArgs(Fox fox, Crane crane)
        {
            Fox = fox;
            Crane = crane;
        }
    }
}
