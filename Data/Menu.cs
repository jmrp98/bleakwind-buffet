using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BleakwindBuffet.Data
{
    public static class Menu
    {
        public static List<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsTBone());
                
            return entrees;
        }
        public static List<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            
            sides.Add(new DragonbornWaffleFries());
            sides.Add(new DragonbornWaffleFries() { Size = Size.Medium });
            sides.Add(new DragonbornWaffleFries() { Size = Size.Large });

            sides.Add(new FriedMiraak());
            sides.Add(new FriedMiraak() { Size = Size.Medium });
            sides.Add(new FriedMiraak() { Size = Size.Large });

            sides.Add(new MadOtarGrits());
            sides.Add(new MadOtarGrits() { Size = Size.Medium });
            sides.Add(new MadOtarGrits() { Size = Size.Large });

            sides.Add(new VokunSalad());
            sides.Add(new VokunSalad() { Size = Size.Medium });
            sides.Add(new VokunSalad() { Size = Size.Large });

            return sides;
        }

        public static List<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();

            drinks.Add(new AretinoAppleJuice());
            drinks.Add(new AretinoAppleJuice() { Size = Size.Medium });
            drinks.Add(new AretinoAppleJuice() { Size = Size.Large });

            drinks.Add(new CandlehearthCoffee());
            drinks.Add(new CandlehearthCoffee() { Size = Size.Medium });
            drinks.Add(new CandlehearthCoffee() { Size = Size.Large });

            drinks.Add(new MarkarthMilk());
            drinks.Add(new MarkarthMilk() { Size = Size.Medium });
            drinks.Add(new MarkarthMilk() { Size = Size.Large });

            drinks.Add(new SailorSoda());
            drinks.Add(new SailorSoda() { Size = Size.Medium });
            drinks.Add(new SailorSoda() { Size = Size.Large });

            drinks.Add(new SailorSoda() { Flavor= SodaFlavor.Blackberry });
            drinks.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Blackberry });
            drinks.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Blackberry });

            drinks.Add(new SailorSoda() { Flavor = SodaFlavor.Grapefruit });
            drinks.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Grapefruit });
            drinks.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Grapefruit });

            drinks.Add(new SailorSoda() { Flavor = SodaFlavor.Lemon });
            drinks.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Lemon });
            drinks.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Lemon });

            drinks.Add(new SailorSoda() { Flavor = SodaFlavor.Peach });
            drinks.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Peach });
            drinks.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Peach });

            drinks.Add(new SailorSoda() { Flavor = SodaFlavor.Watermelon });
            drinks.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Watermelon });
            drinks.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Watermelon });

            drinks.Add(new WarriorWater());
            drinks.Add(new WarriorWater() { Size = Size.Medium });
            drinks.Add(new WarriorWater() { Size = Size.Large });

            return drinks;
        }

        public static List<IOrderItem> FullMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>(Entrees());
            menu.AddRange(Sides());
            menu.AddRange(Drinks())
;
            return menu;
        }
    }

    
}
