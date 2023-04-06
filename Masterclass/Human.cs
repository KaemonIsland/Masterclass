namespace Masterclass
{
    internal class Human
    {
        // Memeber Variables
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;


        // Default Constructor
        public Human()
        {
            firstName = "John";
            lastName = "Doe";
            eyeColor = "Brown";
            age = 0;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // Parameterized Constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // Member Methods

        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, my name is {0} {1}", firstName, lastName);


            Console.WriteLine($"I am {age} year${(age >= 2 ? "s" : "")} old");
            Console.WriteLine("My eye color is {0}", eyeColor);
        }
    }
}
