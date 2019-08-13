//This is using the system
//It's like importing for javascript
using System;
using System.Collections.Generic;
using c_Demo.Math;
using System.Text;
using System.IO;



//This is a collection of classes
namespace c_Demo
{
    //This is classes. It could hold many class. Each class could hold data and method.
    class Program
    {
        //This is our main program. This is the entry point.
        //Static mean method is accessible without instantiating the class
        //Void tell us that this method will not return anything
        static void Main(string[] args)
        {
            //We could also use Var. Var will let the system figure what data they're

            byte number = 3;
            int count = 10;
            float totalPrice = 29.99f;
            char character = 'a';
            string firstName = "toua";
            bool isWorking = true;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            //This is call a format string
            //It take two argument and it will be replace by the value. ie byte.minvaule
            Console.WriteLine("{0},{1}", byte.MinValue, byte.MaxValue);

            //implicate and explicate converting
            //If there no data lost then implicate converting is no problem
            byte byt = 1;
            int i = byt;

            //explicate converting
            float f = 1.0f;
            int iI = (int)f;

            //Non compatible type
            //Cannot change string to a int
            string s = "1234";
            int integer = Convert.ToInt32(s);
            Console.WriteLine(s);

            //Non compatible type overflow
            // string somethingNew = "1234";
            // byte bByte = Convert.ToByte(somethingNew);
            // Console.WriteLine(bByte);

            // This will give us a error.

            //To handle exception of overflowing
            //we need to wrap it in a try & catch block
            try
            {
                string something = "1234";
                byte b = Convert.ToByte(something);
                Console.WriteLine(b);

            }
            catch (System.Exception)
            {

                Console.WriteLine("The number is too big to be converted to a byte");
            }
            //Creating class or a new object is different. They're non-primiate type
            //So we need to allocate memory to them
            // int newNumber ;
            // Person person  = new Person();

            Person john = new Person();
            john.firstName = "john";
            john.lastName = "smith";
            john.SayYourName();
            Calculator calculator = new Calculator();
            var result = calculator.add(1, 2);
            Console.WriteLine("testing the result" + " " + result);

            int[] arryNum = new int[3] { 0, 1, 2 };
            Console.WriteLine("Testing array" + arryNum);
            Demo jonny = new Demo();
            jonny.Name = "jonny";
            jonny.Introduce();

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
            //we need to parse this string into a int
            var methodName = "Express";
            //Enum is a non primiate type. So we need to allocate memory. 
            var methodShipping = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine("testing " + methodShipping);

            //Vaule type
            var Aa = 10;
            var Bb = Aa;
            Bb++;
            Console.WriteLine(string.Format("Aa:{0},Bb{1}", Aa, Bb));

            //Reference type
            var array1 = new int[3] { 0, 2, 5 };
            var array2 = array1;
            array2[0] = 6;
            Console.WriteLine(string.Format("array1[0]:{0},array2[0]:{1}", array1[0], array2[0]));

            //This is an example of a value type
            var vauleTypeNumber = 9;
            increment(vauleTypeNumber);
            Console.WriteLine("testing" + " " + vauleTypeNumber);
            var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var j = 0; j < passwordLength; j++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
                var password = new string(buffer);
                Console.WriteLine(password + " This is password");
                // Console.WriteLine((char)('a' + random.Next(0, 26)));
            }

            //Date
            var dateTime = new DateTime(2019, 8, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("testing the date" + " this is now " + now + " this is today " + today);
            Console.WriteLine(now.ToString("yy-MM-dd"));

            //Time span
            var timeSpan = new TimeSpan(1, 2, 3);

            var myFullName = "Toua Thao ";
            Console.WriteLine("Trim:'{0}' ", myFullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", myFullName.Trim().ToUpper());

            var index = myFullName.IndexOf(' ');

            var sentance = "this is going to be a really really really really really long sentence";
            var summeryWords = StringUsage.summerize(sentance, 30);
            Console.WriteLine(summeryWords);

            //string builder
            var builder = new StringBuilder();
            builder.Append('-', 10);
            Console.WriteLine(builder);

            //Revese name
            Console.WriteLine("What is your name?");
            var yourName = Console.ReadLine();
            var nameReverse = reverseName(yourName);
            Console.WriteLine(" reversed Name " + nameReverse);

            // Take in a number
            var numberTakers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number or (type 'QUIT' to exit):");
                var readNumber = Console.ReadLine();
                if (readNumber.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    numberTakers.Add(Convert.ToInt32(readNumber));
                }
            }
            var uniques = GetUniqueNumber(numberTakers);
                Console.WriteLine("Uniques number:");
                foreach (var numberTake in uniques)
                {
                    Console.WriteLine(numberTake);
                }

                
            }

        public static List<int> GetUniqueNumber(List <int> uniquesNumbers){
            var uniques = new List<int>();
            foreach(var uniquesNumber in uniquesNumbers){
                  if (!uniques.Contains(uniquesNumber))
                {
                    uniques.Add(uniquesNumber);
                    Console.WriteLine("testing the loop " + uniquesNumber);
                }
            }
            return uniques;

        }

        public static string reverseName(string yourName)
        {
            //We make an array that hold character. Inside of the array it hold all the 
            //user name
            var array = new char[yourName.Length];
            //we have our name here
            Console.WriteLine( yourName);
            //Now we do a for loop. To loop through them.
            for (var gg = yourName.Length; gg > 0; gg--)
            {
                //Our array with our name length i
                array[yourName.Length - gg] = yourName[gg - 1];
                Console.WriteLine( array);

            }
            return new string(array);


        }


        public static void increment(int number)
        {
            number += 10;
        }

    }
}
