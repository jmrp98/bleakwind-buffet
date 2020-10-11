/*
 * Author: Jose Mateus Raitz
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent a Mad Otar Grits.
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits : Side
    {

        /// <summary>
        /// Gets and sets the price of the side.
        /// </summary>
        public override double Price
        {

            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.22;


                    case Size.Medium:
                        return 1.58;


                    case Size.Large:
                        return 1.93;

                    default:
                        return 0;

                }
            }

        }

        /// <summary>
        /// Gets and set the calories of the side.
        /// </summary>
        public override uint Calories
        {

            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 105;
                        

                    case Size.Medium:
                        return 142;
                        

                    case Size.Large:
                        return 179;

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
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the default toString method.
        /// </summary>
        /// <returns>The name of the class on a string</returns>
        public override string ToString()
        {
            return Size + " Mad Otar Grits";
        }
    }
}
