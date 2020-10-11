using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing common properties of drinks.
    /// </summary>
    public abstract class Drink :IOrderItem
    {
        /// <summary>
        /// The size of drink.
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public virtual Size Size { get; set; } = Size.Small;
        /// <summary>
        /// The price of drink.
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get;}
        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the drink. 
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
