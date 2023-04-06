namespace Masterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AddUserInput();

            ArrayNotes.StacksAndQueues();
            // A class is a blue print of an Object
            // It has actions/abilities - so called member functions or methods
            // It has properties - so called member variables
            // Inhertiance is possible
            // Can be used like a Datatype (e.g. class String)

            // Object
            // Properties: HP, Amount of Wheels, Lumen, Doors
            // Abilities: Drive, Break, Open Window, Make Light
            // Inheritance: E.g. A5 < Audi < Car

            // Human kaemon = new Human("Kaemon", "Lovendahl", "blue", 29);
            // Human chelsey = new Human("Chelsey", "Lovendahl", "blue", 29);

            // kaemon.IntroduceMyself();

            // Box box = new Box(3, 4, 6);
            // box.DisplayInfo();

            // Members member = new Members();
            // member.Introducing(true);
        }
        // Finalizer for Member is called at the end of Scope!

        static void TypeNotes()
        {
            Console.WriteLine("Hello, World!");

            int age = 15; // This is a variable of type integer
            Console.WriteLine(age);

            float ageExtra = 28.9f;
            Console.WriteLine(ageExtra);

            // Declaring a variable
            int num1;
            // Assigning a value to a variable
            num1 = 13;

            // Declaring and initializing a variable in one go
            int num2 = 23;
            int sum = num1 + num2;

            // Using concatination and string interpolation
            Console.WriteLine("Num1 is " + num1);
            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);
            Console.WriteLine($"num1: {num1} + num2: {num2} is {sum}");

            // Declaring multiple variables at once
            int num3, num4, num5;

            // Using Doubles for very precise (more memory)
            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;

            Console.WriteLine($"d1/d2 is {dDiv}");

            // Using Floats for less precision (less memory)
            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;

            Console.WriteLine($"f1/f2 is {fDiv}");

            // Large numbers!
            long myLongNum = 1231134323232342423;
            long myLongNum2 = 12321323123123123;

            // Working with different data types!

            // doulbe / int is still a double
            double dIDiv = d1 / num1;
            Console.WriteLine($"d1 / num1 is {dIDiv}");

            // STRINGS!!!!!!!!!!!!!!!!!!!!!!!!!!

            string myName = "Kaemon";
            string message = "My name is: ";

            string capsMessage = message.ToUpper();

            string lowerMessage = message.ToLower();

            Console.WriteLine(message + myName);

            // Naming conventions and coding standards!
            // Reasonable variable name
            // Proper method name
            // Always leave comments, look up^

            // SINGLE LINE COMMENT
            /*
             * I can comment
             * on
             * multiple lines!
             */



            // Value type in detail

            // Value type as teh name suggests is a data type which when declared and assigned a value, hold the value directly on its own memeory space.
            // The value type uses a heap to store the value.
            // Value types data types are int, float, long, double, char, bool, decimal, double, etc.

            // Reference type in detail

            // Reference type is a variable type which instead of storing the value in memeory directly, stores teh memory location of the actual data.
            // The variable here stores teh memeory reference of the data and not the data directly
            // Reference type data types are string, class, array, etc.
            // When we copy this referenc type of a data type it will just copy the memory address fot he data so we will then have two variable pointing to the same data.

            // Implicit and Explicit Conversions

            double myDouble = 13.37;
            int myInt;

            // Cast doubl to int
            // EXPLICIT
            myInt = (int)myDouble;

            // IMPLICIT
            int num = 12390542;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            // Type Conversion (double to string)
            string myString = myDouble.ToString(); // "13.37"

            bool sunIsShinging = true;
            string myBool = sunIsShinging.ToString();

            // Parse a string to a number
            string myStringNumber = "15";
            string mySecondStringNumber = "13";
            int numFromString = Int32.Parse(myStringNumber);
            int numFromString2 = Int32.Parse(mySecondStringNumber);

            string result = myStringNumber + mySecondStringNumber;

        }

        static void ConsoleNotes()
        {
            // See below for the XML description comment
            CoolMethod();

            // The Console Class and some of its Methods

            // Prints and keeps the cursor on the SAME line.
            // Console.Write("text here");

            // Prints and puts teh cursor in the NEXT line
            // Console.WriteLine("Text here");

            // Take s a single input of type string and it returns the ASCII value of that input
            // Console.Read();

            // Takes a string or interger input and returns it as the Output value
            // Console.ReadLine();

            // Takes a single input of type string and it returns the Key Info
            // Console.ReadKey();

            // We can change the console colors!!!!!
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("Hello World!");
            Console.Write("Hello!");
            Console.Write("Welcome!");



            /// <summary>
            /// This is a cool method!
            /// </summary>
            static void CoolMethod()
            {
                // cool code
            }

            /// <summary>
            ///  Takes mutliple examples of user input to display text to the console.
            /// </summary>
            static void GetUserInput()
            {
                Console.WriteLine("Enter a string and press enter: ");
                string readInput = Console.ReadLine();
                Console.WriteLine("You have entered {0}", readInput);

                Console.Write("Enter a string and press Enter:");
                int asciiValue = Console.Read();
                Console.WriteLine("ASCII value is {0}", asciiValue);
                Console.ReadKey();
            }

        }

        static void StringManipulation()
        {
            int age = 28;
            string name = "Kaemon";

            // 1. String concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old.");

            // 2. String formatting
            // String formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old", name, age);

            // 3. String Interpolation
            // String Interpolation uses $ at thee  start which will allow us to write our
            // Variables like this {variableName}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old.");

            // 4. Verbatim strings
            // Verbatim strings start with @ and tells the compiler to take the string
            // Literallly and ignore any spaces and escape characters like "\n"
            Console.WriteLine("Verbatim strings");
            Console.WriteLine(@"I'm baby kogi ascot selvage, synth before they sold out franzen cornhole tilde everyday carry meh tonx meditation art party schlitz.
                Mixtape try-hard vibecession banh mi vaporware neutra tumblr gentrify green juice four loko vinyl +1.
                Kickstarter meh yuccie, flannel microdosing pinterest vice iceland jean shorts trust fund pour-over celiac occupy craft beer live-edge. +1 health goth pickled forage. Authentic freegan shaman trust fund polaroid YOLO. Keffiyeh celiac cronut pork belly skateboard tumblr. Crucifix chambray poutine, echo park lo-fi vibecession forage kogi affogato.

                Meh vinyl irony thundercats chicharrones cardigan roof party. Scenester cliche hot chicken try-hard 3 wolf moon, meggings unicorn offal praxis ugh DSA DIY edison bulb.
                Polaroid you probably haven't heard of them wolf fanny pack tattooed bushwick. Keytar mukbang taxidermy kogi, brunch venmo fingerstache cray.
                Tbh shabby chic kickstarter, man braid before they sold out paleo dreamcatcher tumblr kogi sartorial chia. Chicharrones fam franzen tonx, quinoa pop-up vibecession PBR&B sriracha chambray whatever narwhal meggings glossier."
            );

            // Instead of using // to write file paths we can use verbatim strings to make it easier
            // If you remove the @ you will get an error because \U, \A and \D are not valid escape characters
            Console.WriteLine(@"C:\User\Admin\Dog Pictures\Dog1\Super Cool Dog.png");


        }
        static void StringMethods()
        {
            // SubString(int32) - is used to get teh Substring form the string, starting from the specified index.
            // ToLower() - convert string to lowercase
            // ToUpper() - convert string to uppercase
            // Trim() - is used to trim all leading and trailing white space from the string.
            // IndexOf(string) - is used to get the first occurence of hte string or character inside the string
            // IsNullOrWhiteSpace(string) - check if string is null or only empty space
            // In C# the String.Format method is used to insert the object or variable value inside any string.
            // With the String.Format we can replace the value in the specified format.
            // String.Format("any string {index}", object)
            string name = "Kaemon";

            String.Format("My name is {0}", name); // output: "My name is Kaemon"

        }

        static void Variables()
        {
            // Constants are immutable values which are known
            // At compile time and do not change for hte life of the program
            // CONSTANT VALUES
            //const double PI = 3.14159;
            //const int weeksInYear = 52, months = 12;
            //const string myBirthday = "February 15th, 1994";

        }

        // Method Exploration

        // Whenever you want to call a method from a Static method, that method must also be static

        // Void Methods

        // access modifier (static) return type method name (param1, param2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        // Example method that uses
        // Access Specifier
        // Return Type
        // Method name
        // Parameters
        // Method Body
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;

            return result;
        }

        public static void AddUserInput()
        {
            Console.Write("Please provide a number: ");
            string response1 = Console.ReadLine();
            int num1 = Int32.Parse(response1);
            Console.Write("Please provide another number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Multiply {num1} and {num2} equals {num1 * num2}");
        }

        public static void TryCatch()
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try
            {
                // Will cause an error if the input isn't a possible number
                int userInputAsInt = int.Parse(userInput);

                Console.WriteLine(userInputAsInt);
            } catch (FormatException)
            {
                Console.WriteLine("Format Exception: Please enter the correct format next time.");
            } catch (OverflowException)
            {
                Console.WriteLine("The number was too big!");
            } catch (Exception)
            {
                Console.WriteLine("Something went wrong! -_-");
            } finally
            {
                Console.WriteLine("This will always be run!");
            }

        }

        public static void OperatorsUnite()
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators
            num3 = -num1;
            Console.WriteLine($"num3 is {num3}");

            bool isSunny = true;
            Console.WriteLine($"Is it sunny? {!isSunny}");

            // increment operators
            int num4 = 0;
            num4++; // Pre-incrment ++num4
            Console.WriteLine($"Num4 is {num4}");

            // decrement operatos
            int num5 = 0;
            num5--;
            Console.WriteLine($"Num5 is {num5}");

            // Additive and Multiplicitive operators
            int resultAdd = num1 + num2;
            int resultMinus = num1 - num2;
            int resultDivide = num1 / num2;
            int resultMultiply = num1 * num2;
            int resultModulo = num1 % num2;

            // Relational and type operators
            bool isLower;
            isLower = num1 < num2;
            bool isLowerOrEqual = num1 >= num2;
            bool isGreater = num1 > num2;
            bool isGreaterOrEqual = num1 <= num2;
            bool isEqual = num1 == num2;
            bool isNotEqual = num1 != num2;

            // Conditional operators
            bool isLowerAndSunny = isLower && isSunny;
            bool isLowerOrSunny = isLower || isSunny;
        }

        public static void MakingDecisions()
        {
            // If statements
            string temperature = Console.ReadLine();
            int parsedTemp;
            int number;

            if (int.TryParse(temperature, out number))
            {
                parsedTemp = number;
            } else
            {
                parsedTemp = 0;
            }


            if (parsedTemp < 30)
            {
                Console.WriteLine("Put on a coat.");
            } else if (parsedTemp == 30)
            {
                Console.WriteLine("It's 30 degrees F");
            } else {
                Console.WriteLine("Cozy and warm!");
            }

            // Nested If statements
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your username");
            userName = Console.ReadLine();

            if (isRegistered)
            {
                Console.WriteLine("Hi there, registered user");

                if (userName != "")
                {
                    Console.WriteLine($"Hi there, {userName}");

                    if (userName.Equals("Admin"))
                    {
                        Console.WriteLine(" Hi there, Admin");
                    }
                }
            }

            // Switch Cases
            int age = 29;

            switch(age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 29:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("Age not found.");
                    break;
            }

            string userName2 = "Kaemon";

            switch(userName2)
            {
                case "Kaemon":
                    Console.WriteLine("Username is Kaemon");
                    break;
                case "root":
                    Console.WriteLine("Root user");
                    break;
                default:
                    Console.WriteLine("Username is unknown");
                    break;
            }

            // Ternary operators
            // condition ? first_expression : second_expression;
            // condition has to be either true or false
            // The conditional operator is right - associative.
            // The expreession a ? b : c ? d : e,
            // is evaluation as a ? b : (c ? d : e);
            // The conditional operator cannot be overloaded
            int temperature2 = -5;
            string stateOfMatter = temperature2 < 0 ? "solid" : "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

        }
        
        public static void Looping()
        {
            // For Loop
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"The value of i is {i}");

                if (i == 4)
                {
                    Console.WriteLine("i is 4");
                    break;
                }
            };

            // While Loop
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine($"The value of j is {j}");
                j++;
            }

            // Do while
            int k = 0;
            do
            {
                Console.WriteLine($"The value of k is {k}");
                k++;
            } while (k < 10);

            // For Each Loop
            string[] names = { "Kaemon", "Kai", "Kam", "Kammy" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        public static void ObjectOrientedProgramming()
        {

        }
    }
}