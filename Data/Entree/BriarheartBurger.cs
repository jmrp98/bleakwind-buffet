/*
 * Author: Jose Mateus Raitz
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent a Briarheart Burger
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    public class BriarheartBurger
    {
        
        /// <value>
        /// Gets and sets the price of the burger.
        /// </value>
        public double Price => 6.32; 
        

        /// <value>
        /// Gets and sets the calories of the burger.
        /// </value>
        public uint Calories => 732;

        /// <value>
        /// Gets and sets wheter the burger has bun or not.
        /// </value>
        public bool Bun { get; set; } = true;
        /// <value>
        ///  Gets and sets wheter the burger has ketchup or not.
        /// </value>
        public bool Ketchup { get; set; } = true;
        /// <value>
        ///  Gets and sets wheter the burger has mustard or not.
        /// </value>
        public bool Mustard { get; set; } = true;
        /// <value>
        ///  Gets and sets wheter the burger has cheese or not.
        /// </value>
        public bool Cheese { get; set; } = true;

        /// <value>
        ///  Gets and sets wheter the burger has pickles or not.
        /// </value>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Adds Special Instructions for the order according to it's parameters and returns a List with it.
        /// </summary>
        /// /// <returns>A List whith the special instructions added</returns>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Pickle) instructions.Add("Hold pickle");

                return instructions;
            }
        }

        /// <summary>
        /// Overrides the default toString method.
        /// </summary>
        /// <returns>The name of the class on a string</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }

    }

}
