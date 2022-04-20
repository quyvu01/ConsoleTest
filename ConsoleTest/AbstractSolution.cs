using System;
using OneOf;

namespace ConsoleTest
{
    public enum Error
    {
        DrinkingOutOfRange,
        NumbersToGetGiftError,
        PresentOverCondition
    }

    public static class AbstractSolution
    {
        /// <summary>
        /// Drinking plan: Total number of Drinking plan
        /// NumbersToGetGift: Number of Per drinking plan to get the gift
        /// NumberGiftPerOne: Number of gift per one times, when we got enough Drinking
        /// </summary>
        /// <param name="drinkingPlan"></param>
        /// <param name="numbersToGetGift"></param>
        /// <param name="numberGiftPerOne"></param>
        /// <returns></returns>
        public static OneOf<int, Error> CalculateTheQuantity(int drinkingPlan, int numbersToGetGift,
            int numberGiftPerOne)
        {
            if (drinkingPlan < 0 || drinkingPlan > Math.Pow(10, 5)) return Error.DrinkingOutOfRange;
            if (numbersToGetGift < 1) return Error.NumbersToGetGiftError;
            if (numberGiftPerOne >= numbersToGetGift) return Error.PresentOverCondition;
            if (drinkingPlan < numbersToGetGift) return drinkingPlan;
            var numOfGetGift = ((drinkingPlan - numbersToGetGift) % (numbersToGetGift - numberGiftPerOne)) switch
            {
                0 => (drinkingPlan - numbersToGetGift) / (numbersToGetGift - numberGiftPerOne) + 1,
                _ => (int) Math.Ceiling((float) (drinkingPlan - numbersToGetGift) /
                                        (numbersToGetGift - numberGiftPerOne))
            };
            return drinkingPlan + numOfGetGift * numberGiftPerOne;
        }
    }
}