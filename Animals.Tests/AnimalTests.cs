using System;
using Xunit;

namespace Animals.Tests
{
    public class AnimalsShould
    {
        private Animal _animal;
        private Dog _dog;

        public AnimalsShould()
        {
            // new instance of animal
            _animal = new Animal();
            _dog = new Dog();
        }

        [Fact]
        public void SetName()
        {
            _dog.SetName("dog");

            Assert.Equal("dog", _dog.Name);
        }

        [Fact]
        public void SetSpecies()
        {
            _dog.SetSpecies("Schnauzer");

            Assert.Equal("Schnauzer", _dog.Species);
        }
    }
    
}
