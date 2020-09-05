/*
 * Author: Jose Mateus Raitz
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent a MarkarthMilk
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk
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
        /// Gets and sets the price of the drink.
        /// </summary>
        public double Price
        {

            set
            {
                switch (Size)
                {
                    case Enums.Size.Small:
                        Price = 1.05;
                        break;

                    case Enums.Size.Medium:
                        Price = 1.11;
                        break;

                    case Enums.Size.Large:
                        Price = 1.22;
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
                        Calories = 56;
                        break;

                    case Enums.Size.Medium:
                        Calories = 72;
                        break;

                    case Enums.Size.Large:
                        Calories = 93;
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

                return instructions;
            }
        }


        /// <summary>
        /// Overrides the default toString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + "Markarth Milk";
        }
    }
}
