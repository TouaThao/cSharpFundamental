//This is using the system
//It's like importing for javascript
using System;
using c_Demo.Math;


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

            // byte number = 3 ;
            // int count = 10;
            // float totalPrice = 29.99f;
            // char character = 'a';
            // string firstName = "toua";
            // bool isWorking = true;
            // Console.WriteLine(number);
            // Console.WriteLine(count);
            // Console.WriteLine(totalPrice);
            // Console.WriteLine(character);
            // Console.WriteLine(firstName);
            // Console.WriteLine(isWorking);

            //This is call a format string
            //It take two argument and it will be replace by the value. ie byte.minvaule
            Console.WriteLine("{0},{1}", byte.MinValue, byte.MaxValue);

            //implicate and explicate converting
            //If there no data lost then implicate converting is no problem
            // byte  b = 1;
            // int i = b;

            //explicate converting
            // float f = 1.0f;
            // int i = (int)f;

            //Non compatible type
            //Cannot change string to a int
            // string s = "1234";
            // int i = Convert.ToInt32(s);
            // Console.WriteLine(s);

            //Non compatible type overflow
            // string s = "1234";
            // byte b = Convert.ToByte(s);
            // Console.WriteLine(b);
            //This will give us a error.

            //To handle exception of overflowing
            //we need to wrap it in a try & catch block
            try
            {
                string s = "1234";
                byte b = Convert.ToByte(s);
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
            var methodId =3;
            Console.WriteLine((ShippingMethod)methodId);
            //we need to parse this string into a int
            var methodName = "Express";
            //Enum is a non primiate type. So we need to allocate memory. 
            var methodShipping = (ShippingMethod)Enum.Parse(typeof(ShippingMethod),methodName);
            Console.WriteLine("testing "+ methodShipping);

            //Vaule type
            var Aa = 10;
            var Bb = Aa;
            Bb++;
            Console.WriteLine(string.Format("Aa:{0},Bb{1}",Aa,Bb));

            //Reference type
            var array1 = new int[3]{0,2,5};
            var array2 = array1;
            array2[0] = 6;
            Console.WriteLine(string.Format("array1[0]:{0},array2[0]:{1}",array1[0],array2[0]));
            
            //This is an example of a value type
            var vauleTypeNumber = 9;
            increment(vauleTypeNumber);
            Console.WriteLine("testing"+ " " + vauleTypeNumber);
        }

        public static void increment(int number)
        {
                number +=10;
        }



    }
}
