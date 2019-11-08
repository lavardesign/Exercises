using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercises.Classes.Chapter11;

namespace Exercises.Tests.Chapter11
{
    public class SubstancesTests
    {
        [Fact]
        public void CanCreateLiquidInstance()
        {
            IMatter matter = new Liquid("Water", 1);

            Assert.NotNull(matter);
            Assert.Equal("Water", matter.Name);
            Assert.Equal(1, matter.Mass);
            Assert.Equal(States.Liquid, matter.State);
        }

        [Fact]
        public void CanCreatePlasmaInstance()
        {
            IMatter matter = new Plasma("Plasma", 0.01);

            Assert.NotNull(matter);
            Assert.Equal("Plasma", matter.Name);
            Assert.Equal(0.01, matter.Mass);
            Assert.Equal(States.Plasma, matter.State);
        }

        [Fact]
        public void CanCreateSolidInstance()
        {
            IMatter matter = new Solid("Solid", 0.9);

            Assert.NotNull(matter);
            Assert.Equal("Solid", matter.Name);
            Assert.Equal(0.9, matter.Mass);
            Assert.Equal(States.Solid, matter.State);
        }

        [Fact]
        public void CanCreateGasInstance()
        {
            IMatter matter = new Gas("Gas", 0.1);

            Assert.NotNull(matter);
            Assert.Equal("Gas", matter.Name);
            Assert.Equal(0.1, matter.Mass);
            Assert.Equal(States.Gas, matter.State);
        }

        [Fact]
        public void CanCreateSubstanceInstance()
        {
            var substances = new Substances();

            Assert.NotNull(substances);
            Assert.NotEmpty(substances.StateNames);
            Assert.Equal(States.Liquid, substances.GetStateValue("Liquid"));
            Assert.NotEmpty(substances.Get());
            Assert.NotEmpty(substances.Get(m => m.State.Equals(States.Liquid)));
        }
    }
}
