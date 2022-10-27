using System;
using System.Text;

namespace ConsoleApp1
{
  //custom complex datatype can be defined using structure  
    public struct cust
    {
        public int age;
        public string age2;//since Control.ReadLine() only reads string value age has been given in string.
        public int age3;
        public string name;
        public bool isemp;

        //arithmaticDemo
        public int num1;
        public int num2;
        public int add;
        public int sub;
        public int mul;
        public int div;



    }
    public enum directions
    {
        north,
        south,
        east,
        west
    }
    class Program
    {
        static void Main(string[] args)
        {
            //variableDemo();
            //arithmaticDemo();
            //stringDemo();
            //ControlStatementDemo();
            //loopDemo();
            //arrayDemo();
            enumDemo();


        }
        static void variableDemo()

        {
            //Simple declaration of variables with specified datatype
            int age1 = 35;
            string name1 = "walter";
            bool isemp1 = true;
            Console.WriteLine(name1 + "" + age1 + "" + (isemp1 ? "yes" : "no"));

            //declaring custom datatypes through structures
            cust c;
            c.age = 35;
            c.name = "coby";
            c.isemp = true;
            Console.WriteLine(c.name + "" + c.age + "" + (c.isemp ? "yes" : "no"));

            //Reading user input through custom datatypes using structures
            cust c1;
            c1.age2 = Console.ReadLine();
            c1.name = Console.ReadLine();
            c1.isemp = true;
            Console.WriteLine(c1.name + "" + c1.age2);
            Console.WriteLine((c1.isemp ? "yes" : "no"));

            //Reading user input by through custom datatypes using structures
            cust c2;
            c2.age3 = int.Parse(Console.ReadLine());//ReadLine() only reads and prints only string value so 
            ////in order to read integer value it is to be used with int.Parse() method now it will read and integer as well

            c2.name = Console.ReadLine();
            c2.isemp = true;
            Console.WriteLine(c2.name + "" + c2.age3);
            Console.WriteLine((c2.isemp ? "yes" : "no"));


        }
        static void arithmaticDemo()
        {
            //declaring custom datatypes through structures for arithmatic operations
            cust cu;
            cu.num1 = 35;
            cu.num2 = 21;
            cu.add = cu.num1 + cu.num2;
            cu.sub = cu.num1 - cu.num2;
            cu.mul = cu.num1 * cu.num2;
            cu.div = cu.num1 / cu.num2;
            Console.WriteLine(cu.add + "\n" + cu.sub + "\n" + cu.mul + "\n" + cu.div);

            //Simple declaration of variables with specified datatype for arithmatic operations
            int a = 35;
            int b = 21;
            int addition = a + b;
            int substraction = a - b;
            int multiplication = a * b;
            int division = a / b;
            Console.WriteLine(addition + "\n" + substraction + "\n" + multiplication + "\n" + division);



        }

        static void stringDemo()
        {
            //Char can only conatin single character literal
            char ch = 'c';
            char c = char.ToUpper(ch);//convert character to upper case letter
            Console.WriteLine(char.ToUpper(ch));
            Console.WriteLine(c);

           //different fuctions related to string
            string str = "coldblood";
            string str1 = "coldblood";
            Console.WriteLine(str.Length);//Length function
            Console.WriteLine(str.Contains("c"));//Contains(character) function
            Console.WriteLine(str.IndexOf("c"));//IndexOf(character) function
            Console.WriteLine(str.Substring(0, 4));//Substring(start index , end index) function

            //Concatenate string
            //method 1 simple way
            string concat = str + str1;
            Console.WriteLine(concat);
            
            //String is immutable that is why a new string is created after concatenation.No changes will occur in the original strings.

          // method 2(StringBuilder) creating an object
        StringBuilder concat1 = new StringBuilder();
            concat1.Append(str);
            concat1.Append(str1);
            Console.WriteLine(concat);

            //String Format
            Console.WriteLine("your name please: ");
            String name = Console.ReadLine();
            Console.WriteLine("your age please: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Format("your name is {0} and age is {1}", name, age));


        }
        static void ControlStatementDemo()
        {
            ////if else statement
            //Console.WriteLine("enter a number :\t");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a % 2 == 0)
            //    Console.WriteLine("even");
            //else if (a % 3 == 0)
            //    Console.WriteLine("odd");
            //else
            //    Console.WriteLine("enter valid number");

            //switch case
            Console.WriteLine("enter your coice:\n 1. add 2. sub 3. multi 4. div  ");
            int choose = int.Parse(Console.ReadLine());
            Console.WriteLine("enter first no.\t");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second no.\t");
            int num2 = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    int resultadd = num1 + num2;
                    Console.WriteLine(resultadd);
                    break;
                case 2:
                    int resultsub = num1 - num2;
                    Console.WriteLine(resultsub);
                    break;
                case 3:
                    int resultmulti = num1 * num2;
                    Console.WriteLine(resultmulti);
                    break;
                case 4:
                    int resultdiv = num1 / num2;
                    Console.WriteLine(resultdiv);
                    break;
                default:
                    break;
            }

          


        }
        static void loopDemo()
        {

            ////for loop
            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine($"this is value of i: {i}");
            //     for (int j = i + 1; j < 10; j++)
            //     {
            //         Console.WriteLine($"\tthis is value of j:{j}\n");

            //     }
            // }

            // //while loop
            //int a = 0;
            //while (a < 10)
            //{
            //    Console.WriteLine(a);

            //    int j = a + 1;

            //    while (j < 10)
            //    {
            //        Console.WriteLine("\t" + j);
            //        j++;
            //    }
            //    a++;
            //}

            //do-while loop
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);

            //    int j = i + 1;
            //    do
            //    {
            //        Console.WriteLine($"\t{j}");
            //        j++;
            //    } while (j < 10);
            //    i++;

            //} while (i < 10);
            Console.WriteLine("enter a no.");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                int b = a * i;
                Console.WriteLine($"{b}");
            }

        }

        static void arrayDemo()
        {
            //integer array using user input and string.Join
            ////user input in array can only be printed using string.Join
            Console.WriteLine("enter length of the array");
            int len = int.Parse(Console.ReadLine());//asking user to enter length
            int[] arr = new int[len];//declaring and array
            Console.WriteLine("enter array elements");
            //taking user input for elements
            for (int i = 0; i < len; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                    
                }
            
            Console.WriteLine($"\tarray before sorting:{string.Join(",", arr)}");//printing using string.Join

            //int[] arr1= { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //sorting arr
            
            for (int i = 0; i < len; i++)//loop running for element to be compared
            {
                for (int j = i+1; j < len; j++)//loop running for element with which we compare
                {
                    
                    if(arr[i]>arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;


                    }
                }

            }
            Console.WriteLine($"\tarray after sorting:{string.Join(",", arr)}");//printing using string.Join
           

        }
        static void enumDemo()
        {
            //directions dir = directions.north;
            //Console.WriteLine(dir);
            //Console.WriteLine((int)directions.north);
            //string str = "manoman";
            //string s = str.ToUpper();
            //Console.WriteLine(s);
            //Console.WriteLine(str.ToUpper());
            //directions parsed;
            //Enum.TryParse("north" , out parsed);
            //Console.WriteLine(parsed);
            //Console.WriteLine((int)parsed);

            //Enum can be used as a set of fixed constants
            //enum name can be used as a data type as well as value type
            //value of enum constants can be overridden
            //directions d = directions.east;
            //Console.WriteLine(d);
            Console.WriteLine(directions.east);
            //Console.WriteLine((int)d);

            //parsing an enum
            //directions dir;
            //Enum.TryParse("east", out dir);
            //Console.WriteLine(dir);
            //Console.WriteLine((int)dir);
            





        }

        static void methodsDemo()
        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
        }
    }
}
