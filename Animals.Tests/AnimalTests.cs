using System;
using Xunit;

namespace Animals.Tests
{
    public class AnimalsShould
    {
        private Animal _animal;
        private Dog _dog;

        public AnimalShould()
        {
            // new instance of animal
            _animal = new Animal();
            _dog = new Dog();
        }
    }
    public class UnitTest1
    {
        [Fact]
        public void SetName()
        {
            _dog.SetAnimalName("dog");

            Assert.Equal(_dog.Name, "dog");
        }
    }
}
