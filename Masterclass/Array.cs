using System.Collections;

namespace Masterclass
{
    public class ArrayNotes
    {
        // Stores a fized size sequential collection of elements
        // ONLY of the same type
        // All kinds of types: int, string, object, etc.
        // Great to store a collection of data

        // Declaring an array
        // dataType[] arrayName;
        // int[] grades;

        static void Notes(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            Console.WriteLine("Grades at index 0: {0}", grades[0]);

            string input = Console.ReadLine();

            // assign value to array grades at index 0
            grades[0] = int.Parse(input);
            Console.WriteLine("Grades at index 0: {0}", grades[0]);

            // Another way of initializing an array
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            // Third way of initializing an array
            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };

            Console.WriteLine($"Length of gradesOfMathStudentsA: ${gradesOfMathStudentsA.Length}");

            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine($"Element{j} = {nums[j]}");
            }

            int counter = 0;
            foreach (int k in nums)
            {
                Console.WriteLine($"Element{counter} = {k}");
                counter++;
            }

            string[] friends = new string[] { "Chelsey", "Johnny", "Kim", "Aiden", "Finn", "Luna" };

            foreach (string friend in friends)
            {
                Console.WriteLine($"Hello {friend}!");
            }
        }

        static void MultiDimensional()
        {
            // Delcare a 2D array
            // string[,] matrix;

            // 3D Array
            // string[,,] threeD;

            // Two Dimensional Array
            int[,] array2D = new int[,]
            {
                {1, 2, 3 }, // Row 0
                {4, 5, 6}, // Row 1
                {7, 8, 9}, // Row 2
            };

            Console.WriteLine("Central Value is {0}", array2D[1, 1]);

            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001" },
                    {"010", "011" },
                    {"Hi There,", "What's up" },
                },
                {
                    {"100", "101" },
                    {"110", "111" },
                    {"Another One", "fourth one" }
                },
            };

            Console.WriteLine("The first item is {0}", array3D[0, 0, 0]);

            string[,] array2DString = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };

            // Lists the amount of dimensions
            int dimensions = array2DString.Rank;

            int[,] array2D2 = { { 1, 2 }, { 3, 4 }, };
        }

        static void NestedLoops()
        {
            int[,] matrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
            };

            foreach (int num in matrix)
            {
                Console.WriteLine(num + " ");
            }

            // Outer for loop
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // Inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        Console.WriteLine(matrix[i, j] + " ");
                    }
                }
            }
        }

        static bool BoardChecker(string[,] board)
        {
            bool isWinner = false;

            // Horizontal Checks
            for (int i = 0; i < board.GetLength(0); i++)
            {
                string firstItem = board[i, 0];
                bool allMatch = true;
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != firstItem)
                    {
                        allMatch = false;
                    }
                }

                if (allMatch)
                {
                    isWinner = true;
                    break;
                }
            }

            // Vertical Check
            if (!isWinner)
            {
                bool isVerticalMatch = false;
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    {
                        isVerticalMatch = true;
                        break;
                    }
                }

                if (isVerticalMatch)
                {
                    isWinner = true;
                }
            }

            return isWinner;
        }

        // An array within an array
        static void JaggedArrays()
        {
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            // Alternative way
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11 },
                new int[] { 1, 2, 3 },
                new int[] { 13, 21 },
            };

            Console.WriteLine("The value in the middle of the first entry is {0}", jaggedArray2[0][2]);

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray2[i][j]);
                }
            }
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            // Sum all nums in array
            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            // Calculate the average by diving the sum by the size
            average = sum / size;

            return average;
        }


        // Params allows use to pass any number of parameters to a method
        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.WriteLine(sentence[i] + " ");
            }
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            // For each loop to go through the aray of objects
            foreach (object obj in stuff)
            {
                // print each object followed by a space
                Console.WriteLine(obj + " ");
            }
        }

        public static void MinV2(params int[] numbers)
        {
            int min = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                min = Math.Min(min, numbers[i]);
            }
        }

        public static void CollectionStation()
        {
            // What is a collection?
            // Collections are classes that we can use to store a collection of objects
            // Not limited to one type of object
            // No size constraints, it can grow in size as we add more elements

            // Why do we need Collections?
            // We use them to store, manage and manipulate groups of object more efficiently.

            // Adding, deleting, replacing, searching, and copying are examples of what collections can do.

            // Types of collections
            // Non-generic
            // Can store any type of objects
            int num1 = 5;
            float num2 = 3.14f;
            string name = "Kaemon";
            ArrayList myArrList = new ArrayList();
            myArrList.Add(num1);
            myArrList.Add(num2);
            myArrList.Add(name);

            foreach (object element in myArrList)
            {
                // Do stuff
            }

            // Generic
            // Limited to one type of object.
            string animal1 = "Cat";
            string animal2 = "Dog";
            string animal3 = "Bird";

            List<string> myList = new List<string>();

            foreach (string animal in myList)
            {
                // Do Stuff
            }

        }

        public static void HashTables()
        {
            Hashtable table = new Hashtable();
            Student stud1 = new Student(2, "Chelsey", 4.0f);
            Student stud2 = new Student(1, "Kaemon", 3.1f);

            // Add data to a hash table
            table.Add(1, stud2);
            table.Add(2, stud1);

            // Retrieve data from a hash table
            Student storedStudent = (Student)table[1];

            // Iterate over hash table
            foreach (Student student in table)
            {
                Student temp = (Student)student;
                Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", temp.Id, temp.Name, temp.GPA);
            }


            // Iterate over hash table
            foreach (Student student in table.Values)
            {
                Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", student.Id, student.Name, student.GPA);
            }
        }

        public static void HashChallenge()
        {
            Student[] students = new Student[5];

            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            Hashtable studentsHash = new Hashtable();

            foreach (Student student in students)
            {
                if (!studentsHash.ContainsKey(student.Id))
                {
                    studentsHash.Add(student.Id, student);
                } else
                {
                    Console.WriteLine("Sorry, A student with the same ID already Exists");
                }
            }

            foreach (Student student in studentsHash.Values)
            {
                Console.WriteLine($"Student ID: {student.Id}, Name: {student.Name}, GPA: {student.GPA}");
            }

            Console.ReadKey();
        }

        public static void DictionaryNotes()
        {
            // Stores it's value in a key: value pair
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" }
            };

            Employee[] employees = {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Lora", 32, 21),
                new Employee("Secretary", "Petra", 28, 28),
                new Employee("Lead Developer", "Artorias", 55, 35),
                new Employee("Intern", "Ernest", 22, 8),
            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

            foreach (Employee employee in employees)
            {
                employeesDirectory.Add(employee.Role, employee);
            }

            string key = "CEO";

            if (employeesDirectory.ContainsKey(key))
            {
                Employee employee = employeesDirectory[key];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", employee.Name, employee.Role, employee.Salary);
            } else
            {
                Console.WriteLine("No employee found with this key {0}", key);
            }

            Employee result = null;

            if (employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Value Retrieved!");
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", result.Name, result.Role, result.Salary);
            } else
            {
                Console.WriteLine("The key does not exist.");
            }

            // Performing updates
            string keyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(keyToUpdate))
            {
                employeesDirectory[keyToUpdate] = new Employee("HR", "Eleka", 26, 18);
            }

            string keyToRemove = "Intern";

            // Removing Entries
            if (employeesDirectory.Remove(keyToRemove))
            {
                Console.WriteLine("Intern was expelled!");
            }

            Console.ReadKey();
        }

        public static void StacksAndQueues()
        {
            // Stacks
            // Data can be added/removed from the top, LIFO
            // Can't access the elements in the middle
            // Push(Object obj)
            // Object Pop()
            // Object Peek()

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Peek() will return the element at the top of the stack without removing it
            Console.WriteLine(stack.Peek());

            while (stack.Count > 0)
            {
                stack.Pop(); // Removes and returns the last item in the stack.
            }

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            Stack<int> numsStack = new Stack<int>();
            Console.WriteLine("The array in order: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
                numsStack.Push(numbers[i]);
            }

            Console.WriteLine("");

            int index = 0;
            while (numsStack.Count > 0)
            {
                int newNum = numsStack.Pop();
                numbers[index] = newNum;
                index++;
            }
            Console.WriteLine("reversing the array");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Now working with Queues");

            // Queues
            // Data can be added from the back and removed from the front, FIFO
            // Can't access the elements in the middle
            // Enqueue(Object obj)
            // Object Dequeue()
            // Object Peek()

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);


            // Printing the element at teh front of the queue
            Console.WriteLine("The value at the front of the queue is {0}", queue.Peek());

            // Remove an item from the queue
            queue.Dequeue(); // Something different
            Console.WriteLine("The value at the front of the queue is {0}", queue.Peek());

            while (queue.Count > 0)
            {
                Console.WriteLine("The front value {0} was removed form the queue", queue.Dequeue());

                Console.WriteLine("Current queue count is : {0}", queue.Count);
            }

            Order[] orders = new Order[]
            {
                new Order(1, 5),
                new Order(2, 4),
                new Order(6, 12),
            };

            Order[] orders2 = new Order[]
            {
                new Order(3, 5),
                new Order(4, 4),
                new Order(5, 10),
            };

            Queue<Order> orderQ = new Queue<Order>();

            foreach (Order order in orders)
            {
                orderQ.Enqueue(order);
            }

            foreach (Order order in orders2)
            {
                orderQ.Enqueue(order);
            }

            while (orderQ.Count > 0)
            {
                Order currentOrder = orderQ.Dequeue();

                currentOrder.ProcessOrder();
            }


            Console.ReadKey();
        }

    }

    class Student
    {
        // property called ID
        public int Id { get; set; }

        // property called name
        public string Name { get; set; }

        // property called GPA
        public float GPA { get; set; }
        // Simple constructor

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }

    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Rate { get; set; }

        // Yearly Salary = rate/h * days * weeks * months
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        public Employee(string role, string name, int age, int rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }

    class Order
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }

        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderId} processed!");
        }
    }
}
