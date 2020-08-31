using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    class DragonbornWaffleFries
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
                        Price = 0.42;
                        break;

                    case Enums.Size.Medium:
                        Price = 0.76;
                        break;

                    case Enums.Size.Large:
                        Price = 0.96;
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
                        Calories = 77;
                        break;

                    case Enums.Size.Medium:
                        Calories = 89;
                        break;

                    case Enums.Size.Large:
                        Calories = 100;
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
            return Size + " Dragonborn Waffle Fries";
        }

    }
}
