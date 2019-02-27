using System;

namespace BottlesOfBeer
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Output "99 bottles of beer on the wall.  99 bottles of beer.  Take 1 down and pass it around, 98 bottles of beer on the wall.";
            // Count down until there are no more bottles of beer on the wall.
            //int counter;
            //while counter < 100)
            //{
            //    Console.WriteLine((counter) "bottles of beer on the wall" (counter)"bottles of beer. Take one down and pass it around () bottles of beer on the wall.")
            //}

            //Console.ReadLine();
            string beerwall = " bottles of beer on the wall.";
            string beer = " bottles of beer!";
            string down = " take one down and pass it around, ";
            int counter = 10;
            int lessbeer = counter - 1;
            while (counter > 0)
            {
                Console.WriteLine(counter + beerwall + counter + beer + down + lessbeer + beer);
                counter--;
                lessbeer--;
            }
            Console.ReadLine();

        }
    }
}
