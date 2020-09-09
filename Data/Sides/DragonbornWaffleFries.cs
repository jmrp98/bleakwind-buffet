/*
 * Author: Jose Mateus Raitz
 * Class name: DragonbornWaffles.cs
 * Purpose: Class used to represent a Dragonborn Waffle
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// Gets and sets the size of drink.
        /// </summary>
        public Enums.Size Size { set; get; } = Enums.Size.Small;



        /// <summary>
        /// Gets and sets the price of the side.
        /// </summary>
        public double Price
        {

            get
            {
                switch (Size)
                {
                    case Enums.Size.Small:
                        return 0.42;
                        
                    case Enums.Size.Medium:
                        return 0.76;
                        

                    case Enums.Size.Large:
                        return 0.96;

                    default:
                        return 0;
                }
            }

            

        }

        /// <summary>
        /// Gets/sets and set the calories of the side.
        /// </summary>
        public uint Calories
        {

            get
            {
                switch (Size)
                {
                    case Enums.Size.Small:
                        return 77;
                        

                    case Enums.Size.Medium:
                        return 89;
                        

                    case Enums.Size.Large:
                        return 100;

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
                return instructions;
            }
        }


        /// <summary>
        /// Overrides the default toString method.
        /// </summary>
        /// <returns>The name of the class on a string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Dragonborn Waffle Fries";
        }

    }
}
