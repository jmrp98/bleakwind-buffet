/*
 * Author: Jose Mateus Raitz
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent a Candlehearth Coffee
 */
using BleakwindBuffet.Data.Enums;
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
        public Size Size { set; get; } = Size.Small;
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

            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.75;
                        

                    case Size.Medium:
                        return 1.25;
                        

                    case Size.Large:
                        return 1.75;

                    default:
                        return 0;
                }
            }

            

        }

        /// <summary>
        /// Gets and set the calories of the drink.
        /// </summary>
        public uint Calories
        {

            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 7;
                        

                    case Size.Medium:
                        return 10;
                        

                    case Size.Large:
                        return 20;

                    default:
                        return 0;
                }
            }


        }

        /// <summary>
        /// Adds Special Instructions for the order according to it's parameters and returns a List with it.
        /// </summary>
        /// /// <returns>A List whith the special instructions added</returns>
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
        /// <returns>The name of the class on a string</returns>
        public override string ToString()
        {
            string toString;
            if (!Decaf)
                toString = " Candlehearth Coffee";
            else
                toString = " Decaf Candlehearth Coffee";

            return Size.ToString() + toString;
        }

    }
}
