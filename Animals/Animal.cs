using System;

namespace Animals
{
    class Animal
    {
        // Animal Class Properties
        private string _name;
        private string _species;

        // Animal Class Accessor Method
        public string Name { get { return _name;} set; }
        public string Species { get { return _species;} set; }

        // Set Animal Name Method
        public void SetAnimalName(string name)
        {
            _name = name;
        }
        // Set Animal Species Method
        public void SetAnimalSpecies(string species)
        {
            _species = species;
        }

    }
}
