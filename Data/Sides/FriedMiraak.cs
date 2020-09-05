using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak
    {
        /// <summary>
        /// Gets the size of drink.
        /// </summary>
        public Enums.Size Size { set; get; } = Enums.Size.Small;



        /// <summary>
        /// Gets and sets the price of the side.
        /// </summary>
        public double Price
        {

            set
            {
                switch (Size)
                {
                    case Enums.Size.Small:
                        Price = 178;
                        break;

                    case Enums.Size.Medium:
                        Price = 2.01;
                        break;

                    case Enums.Size.Large:
                        Price = 2.88;
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
                        Calories = 151;
                        break;

                    case Enums.Size.Medium:
                        Calories = 236;
                        break;

                    case Enums.Size.Large:
                        Calories = 306;
                        break;






                }
            }

            get => Calories;

        }



        /// <summary>
        /// Adds Special Instructions and returns a List with it.
        /// </summary>
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
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " Fried Miraak";
        }
    }
}
