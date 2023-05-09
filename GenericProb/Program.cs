using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProb
{
    //Generic means General From and do not have return type
    // it means not specific or particular data type
    // "<>" this angle bracate  with type name
    //TypeName<T> T is your Type Parameter
    //Generic allow us to create single class or method that can be use diff data Type
    //Advantage : we can reuse our code

    public  class Program
    {
        public static void Main(string[] args)
        {
            GenericClass<string> genericClass = new GenericClass<string>("Krishna");
            GenericClass<int> generic = new GenericClass<int>(41);
            GenericClass<double> genericdouble = new GenericClass<double>(2.345);

            genericClass.GenericMethod("Raj");
            generic.GenericMethod(45);
            genericdouble.GenericMethod(3.12);
            genericClass.GenericMethodDemo<int>(78);
            genericClass.GenericMethodDemo<double>(5.56);
            Console.ReadLine();


        }
    }
}
