using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
    {
        /// <summary>
        /// Gets the size of drink.
        /// </summary>
        public Enums.Size Size { set; get; } = Enums.Size.Small;



        /// <summary>
        /// Adds Special Instructions for the order according to it's parameters and returns a List with it.
        /// </summary>
        /// /// <returns>A List whith the special instructions added</returns>
        public double Price
        {

            set
            {
                switch (Size)
                {
                    case Enums.Size.Small:
                        Price = 1.22;
                        break;

                    case Enums.Size.Medium:
                        Price = 1.58;
                        break;

                    case Enums.Size.Large:
                        Price = 1.93;
                        break;






                }
            }

            get => Price;

        }

        /// <summary>
        /// Gets and set the calories of the side.
        /// </summary>
        public uint Calories
        {

            set
            {
                switch (Size)
                {
                    case Enums.Size.Small:
                        Calories = 105;
                        break;

                    case Enums.Size.Medium:
                        Calories = 142;
                        break;

                    case Enums.Size.Large:
                        Calories = 179;
                        break;






                }
            }

            get => Calories;

        }


        /// <summary>
        /// Adds Special Instructions for the order according to it's parameters and returns a List with it.
        /// </summary>
        /// /// <returns>A List whith the special instructions added</returns>
        public List<string> SpecialInstructions
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
            return Size + " Mad Otar Grids";
        }
    }
}
