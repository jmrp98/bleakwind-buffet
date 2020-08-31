using BleakwindBuffet.Data.Enums;
using Data.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    class SailorSoda
    {
        /// <summary>
        /// Gets the size of drink.
        /// </summary>
        public Enums.Size Size { set; get; } = Enums.Size.Small;
        /// <summary>
        /// Gets the flavor of the drink.
        /// </summary>
        public SodaFlavor Flavor { set; get; } = SodaFlavor.Cherry;
        /// <summary>
        /// Gets wheter the drink has ice or not.
        /// </summary>
        public bool Ice { get; set; } = true;
       
        /// <summary>
        /// Gets and sets the price of the drink.
        /// </summary>
        public double Price
        {

            set
            {
                switch(Size)
                {
                    case Enums.Size.Small:
                        Price = 1.42;
                        break;

                    case Enums.Size.Medium:
                        Price = 1.73;
                        break;

                    case Enums.Size.Large:
                        Price = 2.07;
                        break;






                }
            }

            get => Price ;
            
        }

        /// <summary>
        /// Gets and set the calories of the drink.
        /// </summary>
        public uint Calories
        {

            set
            {
                switch (Size)
                {
                    case Enums.Size.Small:
                        Calories = 117;
                        break;

                    case Enums.Size.Medium:
                        Calories = 153;
                        break;

                    case Enums.Size.Large:
                        Calories = 205;
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
                if (!Ice) instructions.Add("Hold ice");

                return instructions;
            }
        }


        /// <summary>
        /// Overrides the default toString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size +" "+ Flavor+ " Sailor Soda";
        }
    }
}
