


using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak
    {
        /// <summary>
        /// Gets and sets the size of drink.
        /// </summary>
        public Size Size { set; get; } = Size.Small;



        /// <summary>
        /// Gets and sets the price of the side.
        /// </summary>
        public double Price
        {

            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.78;
                       

                    case Size.Medium:
                        return 2.01;
                        

                    case Size.Large:
                        return 2.88;

                    default:
                        return 0;
                }
            }

            

        }

        /// <summary>
        /// Gets and sets the calories of the side.
        /// </summary>
        public uint Calories
        {

            get
            {
                switch (Size)
                {
                    case Enums.Size.Small:
                        return 151;
                        

                    case Enums.Size.Medium:
                        return 236;
                        

                    case Enums.Size.Large:
                        return 306;

                    default:
                        return 0;
   

                }
            }

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
            return Size.ToString() + " Fried Miraak";
        }
    }
}
