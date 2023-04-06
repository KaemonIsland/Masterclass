namespace Masterclass
{
    public class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary = 20000;

        // member - public field
        public int age;

        // properties start with a capital letter
        public string JobTitle
        {
            get
            {
                return JobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        // public constructor
        public Members()
        {
            memberName = "kaemon";
            jobTitle = "student";
            age = 20;
            salary = 60000;
        }

        // member - finalizer - destructor
        ~Members()
        {
            // Cleanup statements
            Console.WriteLine("Deconstruction of Members object");
        }

        // public member method
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            } else
            {
                Console.WriteLine("Hello my name is {0}, and my job title is {1}. I'm {2} years old", "kaemon", jobTitle, age);
            };
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

    }
}
