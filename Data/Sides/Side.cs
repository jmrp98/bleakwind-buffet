using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing common properties of sides.
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// The size of side.
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public virtual Size Size { get; set; } = Size.Small;
        /// <summary>
        /// The price of side.
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// The calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the side. 
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
