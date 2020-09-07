/*
 * Author: Jose Mateus Raitz
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent a WarriorWater
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater
    {
        /// <summary>
        /// Gets the size of drink.
        /// </summary>
        public Enums.Size Size { set; get; } = Enums.Size.Small;
        /// <summary>
        /// Gets wheter the drink has ice or not.
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// Gets and sets wheter the water has lemon or not.
        /// </summary>
        public bool Lemon { get; set; } = false;
        
        
        
        /// <summary>
        /// Gets and sets the price of the drink.
        /// </summary>
        public double Price { get; set; } = 0.00;
        /// <summary>
        /// Gets and sets the calories of the drink.
        /// </summary>
        public uint Calories { get; set; } = 0;

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
                if (Lemon) instructions.Add("Add lemon");

                return instructions;
            }
        }

        /// <summary>
        /// Overrides the default toString method.
        /// </summary>
        /// <returns>The name of the class on a string</returns>
        public override string ToString()
        {
            return Size + "Warrior Water";
        }

    }
}
