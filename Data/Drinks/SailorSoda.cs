/*
 * Author: Jose Mateus Raitz
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent a Sailor Soda
 */



using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        /// <summary>
        /// Gets/sets the size of drink.
        /// </summary>
        public Size Size { set; get; } = Size.Small;
        /// <summary>
        /// Gets/sets the flavor of the drink.
        /// </summary>
        public SodaFlavor Flavor { set; get; } = SodaFlavor.Cherry;
        /// <summary>
        /// Gets/sets wheter the drink has ice or not.
        /// </summary>
        public bool Ice { get; set; } = true;
       
        /// <summary>
        /// Gets/sets and sets the price of the drink.
        /// </summary>
        public double Price
        {

            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 1.42;
                       

                    case Size.Medium:
                        return 1.74;
                        

                    case Size.Large:
                        return 2.07;

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
                        return 117;
                        

                    case Size.Medium:
                        return 153;
                        

                    case Size.Large:
                        return 205;

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
                if (!Ice) instructions.Add("Hold ice");

                return instructions;
            }
        }


        /// <summary>
        /// Overrides the default toString method.
        /// </summary>
        /// <returns>The name of the class on a string</returns>
        public override string ToString()
        {
            return Size.ToString() +" "+ Flavor+ " Sailor Soda";
        }
    }
}
