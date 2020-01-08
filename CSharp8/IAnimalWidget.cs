using System;
using System.Runtime.CompilerServices;

namespace AmazingAnimalWidgets
{
    public interface IAnimalWidget
    {
        private static int AmountToFeed = 10;

        //this is used to set the value 
        static void SetAmountToFeed(int amount)
        {
            AmountToFeed = amount;
        }

        string Name { get; }

        int Happiness { get; set; }

        void Feed(int amnt=0)
        {
            Happiness += AmountToFeed;
        }
    }
}
