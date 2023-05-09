using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProb
{
    public  class GenericClass<T>
    {
        //variable of type T
        public T data;
        //Generic constructor...............
        public GenericClass(T data)
        {
            this.data = data;
            Console.WriteLine("Data :"+this.data);


        }
        //Generic Method
        public void GenericMethod(T data)
        {
            Console.WriteLine("Data method :"+data);
        }
        public void GenericMethodDemo<T>(T data)
        {
            Console.WriteLine("Data methodTwo :" + data);
        }


    }
}
