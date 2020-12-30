using System;

namespace Pelmen
{
    class Program
    {
        static void Main(string[] args)
        {
            Pelmeni someCoffeeDrink = new Bavarskie();
            Cupecheskie espresso = new Cupecheskie();
            someCoffeeDrink.Make();
            espresso.Make();
        }
    }
}
