using System;
using Xunit;

namespace Animals.Tests
{
    public class AnimalsShould
    {
        private Animal _animal;
        private Dog _dog;

        public void AnimalShould()
        {
            // new instance of animal
            _animal = new Animal();
            _dog = new Dog();
        }

        [Fact]
        public void SetName()
        {
            _dog.SetSpecies("dog");

            Assert.Equal(_dog.Name, "dog");
        }

        [Fact]
        public void SetSpecies()
        {
            _dog.SetSpecies("Schnauzer");

            Assert.Equal(_dog.Species, "Schnauzer");
        }
    }
    
}
