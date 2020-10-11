/*
 * Author: Jose Mateus Raitz
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent a Philly Poacher
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    public class PhillyPoacher : Entree
    {
        /// <value>
        /// Gets and sets the price of the sandwich.
        /// </value>
        public override double Price => 7.23;
        /// <value>
        /// Gets and sets the calories of the sandwich.
        /// </value>
        public override uint Calories => 784;

        /// <value>
        /// Gets and sets wheter the sandwhich has sirloin or not.
        /// </value>
        public bool Sirloin { get; set; } = true;
        /// <value>
        /// Gets and sets wheter the sandwhich has onion or not.
        /// </value>
        public bool Onion { get; set; } = true;
        /// <value>
        /// Gets and sets wheter the sandwhich has rolls or not.
        /// </value>
        public bool Roll { get; set; } = true;

        /// <summary>
        /// Adds Special Instructions for the order according to it's parameters and returns a List with it.
        /// </summary>
        /// /// <returns>A List whith the special instructions added</returns>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");


                return instructions;
            }
        }

        /// <summary>
        /// Overrides the default toString method.
        /// </summary>
        /// <returns>The name of the class on a string</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }


    }
}
