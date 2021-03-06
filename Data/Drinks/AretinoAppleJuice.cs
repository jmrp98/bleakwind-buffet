﻿/*
 * Author: Jose Mateus Raitz
 * Class name: ArentinoAppleJuice.cs
 * Purpose: Class used to represent an Arentino Apple Juice
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice : Drink
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
                        return 0.62;
                        

                    case Size.Medium:
                        return 0.87;
                        

                    case Size.Large:
                        return  1.01;

                    default:
                        return 123;

                }
            }

        }

        /// <summary>
        /// Gets and set the calories of the drink.
        /// </summary>
        public override uint Calories
        {

            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 44;
                        

                    case Size.Medium:
                        return  88;
                        
                    case Size.Large:
                        return 132;

                    default:
                        return 123;


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
            return Size.ToString() + " Aretino Apple Juice";
        }
    }
}
