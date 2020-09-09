/*
 * Author: Jose Mateus Raitz
 * Class name: GardenOrcOmelete.cs
 * Purpose: Class used to represent a Garden Orc Omellete
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
   public class GardenOrcOmelette
    {
        /// <value>
        /// Gets the price of the omelette.
        /// </value>
        public double Price => 4.57;
        /// <value>
        /// Gets the calories of the omelette.
        /// </value>
        public uint Calories => 404;
        /// <value>
        ///  States wheter the omelette has broccoli or not.
        /// </value>
        public bool Broccoli { get; set; } = true;
        /// <value>
        ///  States wheter the omelette has mushrooms or not.
        /// </value>
        public bool Mushrooms { get; set; } = true;
        /// <value>
        ///  States wheter the omelette has tomatoes or not.
        /// </value>
        public bool Tomato { get; set; } = true;
        /// <value>
        ///  States wheter the omelette has cheddar or not.
        /// </value>
        public bool Cheddar { get; set; } = true;


        /// <summary>
        /// Adds Special Instructions for the order according to it's parameters and returns a List with it.
        /// </summary>
        /// /// <returns>A List whith the special instructions added</returns>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");


                return instructions;
            }
        }

        /// <summary>
        /// Overrides the default toString method.
        /// </summary>
        /// <returns>The name of the class on a string</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }

    }
}
