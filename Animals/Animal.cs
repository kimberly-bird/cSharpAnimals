namespace Animals
{
    public class Animal
    {
        // Animal Class Properties
        private string _name;
        private string _species;

        // Animal Class Accessor Method
        public string Name { get; set; }
        public string Species { get; set; }

        // Set Animal Name Method
        public void SetName(string name)
        {
            _name = name;
        }
        // Set Animal Species Method
        public void SetSpecies(string species)
        {
            _species = species;
        }

    }
}
