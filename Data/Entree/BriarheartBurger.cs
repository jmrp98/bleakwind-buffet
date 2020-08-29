using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    public class BriarheartBurger
    {
        
        /// <summary>
        /// Gets the price of the burger.
        /// </summary>
        public double Price
        {
            get => 6.32; 
        }

        /// <summary>
        /// Gets the calories of the burger.
        /// </summary>
        public uint Calories => 732;

        public bool Bun { get; set; } = true;
        public bool Ketchup { get; set; } = true;
        public bool Mustard { get; set; } = true;
        public bool Cheese { get; set; } = true;

        public bool Pickle { get; set; } = true;

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

        public override string ToString()
        {
            return "Briarheart Burger";
        }

    }

}
