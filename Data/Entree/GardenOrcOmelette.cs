using System;
using System.Collections.Generic;
using System.Text;

namespace BlankwindBuffet.Data.Entree
{
   public class GardenOrcOmelette
    {
        public double Price => 4.57;
        public uint Calories => 404;
        public bool Broccoli { get; set; } = true;
        public bool Mushrooms { get; set; } = true;
        public bool Tomatoe { get; set; } = true;
        public bool Cheddar { get; set; } = true;


        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomatoe) instructions.Add("Hold tomatoe");
                if (!Cheddar) instructions.Add("Hold cheedar");


                return instructions;
            }
        }

        public override string ToString()
        {
            return "Garden Orc Omellete";
        }

    }
}
