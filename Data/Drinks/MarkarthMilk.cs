/*
 * Author: Jose Mateus Raitz
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent a Markarth Milk
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk: Drink
    {
       
        /// <summary>
        /// Gets/sets wheter the drink has ice or not.
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Gets/sets and sets the price of the drink.
        /// </summary>
        public override double Price
        {

            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.05;
                        

                    case Size.Medium:
                        return 1.11;
                        

                    case Size.Large:
                        return 1.22;

                    default:
                        return 0;

                }
            }

            

        }

        /// <summary>
        /// Gets and sets the calories of the drink.
        /// </summary>
        public override uint Calories
        {

            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 56;
                       

                    case Size.Medium:
                        return 72;
                       

                    case Size.Large:
                        return 93;

                    default:
                        return 0;
                        
                }
            }

        }

        /// <summary>
        /// Adds Special Instructions for the order according to it's parameters and returns a List with it.
        /// </summary>
        /// /// <returns>A List whith the special instructions added</returns>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");

                return instructions;
            }
        }


        /// <summary>
        /// Overrides the default toString method.
        /// </summary>
        /// <returns>The name of the class on a string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Markarth Milk";
        }
    }
}
