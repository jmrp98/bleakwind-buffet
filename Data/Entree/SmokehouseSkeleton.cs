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
    public class SmokehouseSkeleton : Entree
    {
        /// <value>
        /// Gets and sets the price of the breakfast combo.
        /// </value>
        public override double Price => 5.62;

        /// <value>
        /// Gets and sets the calories  of the breakfast combo.
        /// </value>
        public override uint Calories => 602;
        /// <value>
        /// States wheter the breakfast combo has sausage link or not.
        /// </value>
        public bool SausageLink { get; set;} = true;
        /// <value>
        /// States wheter the breakfast combo has hash browns or not.
        /// </value>
        public bool HashBrowns { get; set; } = true;
        /// <value>
        /// States wheter the breakfast combo has pancake or not.
        /// </value>
        public bool Pancake { get; set; } = true;
        /// <value>
        /// States wheter the breakfast combo has eggs or not.
        /// </value>
        public bool Egg{ get; set; } = true;

        /// <summary>
        /// Adds Special Instructions for the order according to it's parameters and returns a List with it.
        /// </summary>
        /// /// <returns>A List whith the special instructions added</returns>
        public override List<string> SpecialInstructions
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

        /// <summary>
        /// Overrides the default toString method.
        /// </summary>
        /// <returns>The name of the class on a string</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
