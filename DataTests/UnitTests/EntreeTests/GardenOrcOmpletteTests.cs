/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeEntree()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(om);
        }
        [Fact]
        public void ShouldBeIOrderItems()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(om);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            Assert.True(om.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            Assert.True(om.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            Assert.True(om.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            Assert.True(om.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            om.Broccoli = false;
            Assert.False(om.Broccoli);
            om.Broccoli = true;
            Assert.True(om.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            om.Mushrooms = false;
            Assert.False(om.Mushrooms);
            om.Mushrooms = true;
            Assert.True(om.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            om.Tomato = false;
            Assert.False(om.Tomato);
            om.Tomato = true;
            Assert.True(om.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            om.Cheddar = false;
            Assert.False(om.Cheddar);
            om.Cheddar = true;
            Assert.True(om.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            Assert.Equal(4.57, om.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            Assert.Equal(404, (double)om.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            om.Broccoli = includeBroccoli;
            om.Mushrooms = includeMushrooms;
            om.Tomato = includeTomato;
            om.Cheddar = includeCheddar;

            if(includeBroccoli && includeMushrooms && includeTomato && includeCheddar)
            {
                Assert.Empty(om.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold broccoli", om.SpecialInstructions);
                Assert.Contains("Hold mushrooms", om.SpecialInstructions);
                Assert.Contains("Hold tomato", om.SpecialInstructions);
                Assert.Contains("Hold cheddar", om.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", om.ToString());
        }
    }
}