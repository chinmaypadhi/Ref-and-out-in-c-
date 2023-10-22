using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_and_out_paramiter
{
    //the main use of ref and out is to return multiple vale without return type
    //In case of ref same memory location useed 
    //in out always create new memory location.(Need to create new variable with initialization)

    class myClass
    {
        public void RefFunction(ref string myName, ref int myage )
        {
            myName = myName + " " + "Padhi";
            myage = myage +12;
        }
        public void outFunction(out string myName, out int myage)
        {
            //Need to assign value in case of out param
            myName = "";
            myage = 0;
            myName = myName + " " + "sahu";
            myage = myage + 13;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass obj = new myClass();
            string name = "chinmay";
            int age = 14;
            obj.outFunction(out name, out age);
            Console.WriteLine("My name is "+name+"and my age is "+age);
            obj.RefFunction(ref name, ref age);
            Console.WriteLine("My name is " + name + "and my age is " + age);
            Console.Read();
        }
    }
}
