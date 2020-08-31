﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    class WarriorWater
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
        /// Adds Special Instructions and returns a List with it.
        /// </summary>
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
        /// <returns></returns>
        public override string ToString()
        {
            return Size + "Warrior Water";
        }

    }
}
