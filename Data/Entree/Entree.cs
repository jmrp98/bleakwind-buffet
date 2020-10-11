using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    /// <summary>
    /// A base class representing common properties of entrees.
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <sum>
        /// The price of entree.
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// The calories of the entree.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the entre. 
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
