/*
 * Author: Jose Mateus Raitz
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent a Thugs T-Bone
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    public class ThugsTBone : Entree
    {
        /// <value>
        /// Gets and sets the price of the T-Bone.
        /// </value>
        public override double Price => 6.44;
        /// <value>
        /// Gets and sets the calories of the T-Bone.
        /// </value>
        public override uint Calories => 982;


        /// <summary>
        /// Adds Special Instructions for the order according to it's parameters and returns a List with it.
        /// </summary>
        /// /// <returns>A List whith the special instructions added</returns>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
               
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the default toString method.
        /// </summary>
        /// <returns>The name of the class on a string</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
