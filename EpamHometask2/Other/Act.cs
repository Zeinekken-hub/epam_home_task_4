using System;

namespace EpamHometask2
{
    class Act : IDisplayable
    {
        public Act(string text)
        {
            Text = text;
        }
        public string Text { get; set; }
        public void Display()
        {
            Console.WriteLine(Text);
        }
    }
}
