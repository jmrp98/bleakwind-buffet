/*
 * Author: Jose Mateus Raitz
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent a Candlehearth Coffee
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
    {
        /// <summary>
        /// Gets the size of drink.
        /// </summary>
        public Enums.Size Size { set; get; } = Enums.Size.Small;
        /// <summary>
        /// Gets wheter the drink has ice or not.
        /// </summary>
        public bool Ice { get; set; } = false;
        /// <summary>
        /// Gets wheter the coffee has room for cream or not.
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        /// <summary>
        /// Gets wheter the coffee is decaf or not.
        /// </summary>
        public bool Decaf { get; set; } = false;
        
        
        /// <summary>
        /// Gets and sets the price of the drink.
        /// </summary>
        public double Price
        {

            set
            {
                switch (Size)
                {
                    case Enums.Size.Small:
                        Price = 0.75;
                        break;

                    case Enums.Size.Medium:
                        Price = 1.25;
                        break;

                    case Enums.Size.Large:
                        Price = 1.75;
                        break;






                }
            }

            get => Price;

        }

        /// <summary>
        /// Gets and set the calories of the drink.
        /// </summary>
        public uint Calories
        {

            set
            {
                switch (Size)
                {
                    case Enums.Size.Small:
                        Calories = 7;
                        break;

                    case Enums.Size.Medium:
                        Calories = 10;
                        break;

                    case Enums.Size.Large:
                        Calories = 20;
                        break;






                }
            }

            get => Calories;

        }

        /// <summary>
        /// Adds Special Instructions and returns a List with it.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");

                return instructions;
            }
        }


        /// <summary>
        /// Overrides the default toString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string toString;
            if (!Decaf)
                toString = "Candlerhearth Coffe";
            else
                toString = "Decaf Candlehearth Coffe";

            return toString + " " + Size;
        }

    }
}
