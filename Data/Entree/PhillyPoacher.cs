using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    public class PhillyPoacher
    {
        public double Price => 7.23;
        public uint Calories => 784;

        public bool Sirloin { get; set; } = true;
        public bool Onion { get; set; } = true;
        public bool Roll { get; set; } = true;

        public List<string> SpecialInstructions
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

        public override string ToString()
        {
            return "Philly Poacher";
        }


    }
}
