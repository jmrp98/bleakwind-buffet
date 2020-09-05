/*
 * Author: Jose Mateus Raitz
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent a Smokehouse Skeleton
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    public class SmokehouseSkeleton
    {
        public double Price => 5.62;
        public uint Calories => 602;

        public bool SausageLink { get; set; } = true;
        public bool HashBrowns { get; set; } = true; 
        public bool Pancake { get; set; } = true;
        public bool Egg{ get; set; } = true;

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold egg");
                if (!Pancake) instructions.Add("Hold pancake");
                if (!HashBrowns) instructions.Add("Hold hash browns");


                return instructions;
            }
        }
    }
}
