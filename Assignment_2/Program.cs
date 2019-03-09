using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//---------- Nirmal Patel------- C0730194-------
//-----------Harpreet Singh------C0727128-------
namespace DelegatesAndEvents
{
    delegate void ExampleDelegate(string xyz);
    class Program
    {
        public static void Method1(string xyz)
        {
            Console.WriteLine(xyz + " Method1");
        }
        public static void Method2(string xyz)
        {
            Console.WriteLine(xyz + " Method2");
        }
        public static void Main(string[] args)
        {
            ExampleDelegate ex1Delegate, ex2Delegate, ex3Delegate, myDelegate;
            ex1Delegate = new ExampleDelegate(Method1);
            ex2Delegate = new ExampleDelegate(Method2);
            ex3Delegate = ex1Delegate + ex2Delegate;
            myDelegate = ex1Delegate - ex2Delegate;
            ex1Delegate("AAA");
            ex1Delegate("BBB");
            ex1Delegate("CCC");
            ex1Delegate("DDD");
            myDelegate = ex3Delegate - ex1Delegate;
            ex1Delegate("EEE");
            myDelegate = ex3Delegate - ex2Delegate;
            ex1Delegate("FFF");
            Console.ReadLine();


        }
    }

}