/*
 * Planet Temps
 * 12/11/2020
 * Takes a planet position from the user and outputs the corresponding planet and then gives a 
 * semi-nonsense temperature description
 */



using System;

//brings in the methods from the console class so we don't need to call on Console each time
using static System.Console; 

namespace PlanetTemps
{
    class Planets
    {
        //sets up enmeration of Planets, gives Mercery the value of one which will change the default values of the other planets (Venus = 2, Earth =3,...)
        enum Planet
        {
            MERCURY = 1, VENUS, EARTH, MARS, JUPITER,
            SATURN, URANUS, NEPTUNE
        }
        static void Main()
        {
            Planet planet;
            int position;

            Write("Enter a number to see the planet at that position >> ");
            position = Convert.ToInt32(ReadLine()); //gets user input and converts to integer
            
            
            WriteLine("You entered " + position);
            planet = (Planet)position; // casts user input to the coresponding planet 
            WriteLine("{0} is {1} planet(s) from the sun", planet, (position));

            /*
             * Conditional statement that checks to see if the planet result is equivlent to various conditions
             * if it is it will run the code for that condition and exit the conditional statement
             */
            switch (planet)
            {
                case Planet.MERCURY:
                case Planet.VENUS: //if the planet is MERCURY or VENUS it will have the same result
                    WriteLine("Average temp is REALLY REALLY HOT");
                    break;
                case Planet.EARTH:
                    WriteLine("Pretty hot");
                    break;
                case Planet.MARS:
                    WriteLine("Cold");
                    break;
                case Planet.JUPITER:
                case Planet.SATURN:
                case Planet.NEPTUNE:
                case Planet.URANUS: //if the planet is JUPITER, SATURN, NEPTUNE, or URANUS it will have the same result
                    WriteLine("This is a gas planet, you can't stand on it");
                    break;
                default: //if none of the other cases match
                    WriteLine("No planet matches this");
                    break;
            }
        }
    }
}
