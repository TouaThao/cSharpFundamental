using System;
namespace c_Demo
{
     //Class. public is the access modifier.
        public class Demo {
                //Inside here is a field or varible. It could also contain method
                public string Name = "null";

                public void Introduce(){
                    Console.WriteLine("Hello world This is from demo" + " " + Name);
                }
        }
}