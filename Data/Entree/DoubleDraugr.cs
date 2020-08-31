/*
 * Author: Jose Mateus Raitz
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent a Briarheart Burger
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    public class DoubleDraugr
    {
        /// <summary>
        /// Gets the price of the burger.
        /// </summary>
        public double Price => 7.32;
        /// <summary>
        /// Gets the calories of the burger.
        /// </summary>
        public uint Calories => 843;
        /// <summary>
        /// States wheter the burger has bun or not.
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        ///  States wheter the ketchup has bun or not.
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        ///  States wheter the burger has mustard or not.
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        ///  States wheter the burger has cheese or not.
        /// </summary>
        public bool Cheese { get; set; } = true;
        /// <summary>
        ///  States wheter the burger has pickles or not.
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        ///  States wheter the burger has tomatoes or not.
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        ///  States wheter the burger has lettuce or not.
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        ///  States wheter the burger has mayo or not.
        /// </summary>
        public bool Mayo { get; set; } = true;


        /// <summary>
        /// Adds Special Instructions and returns a List with it.
        /// </summary>
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
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
              

                return instructions;
            }
        }



        /// <summary>
        /// Overrides the default toString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Draugr Burger";
        }
    }
}
