using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//---------- Nirmal Patel------- C0730194-------
//-----------Harpreet Singh------C0727128-------
namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExercises de = new DelegateExercises();
            de.Method3();
            Console.Read();
        }
    }

    public class DelegateExercises
    {
        public delegate void MyDelegate();
        void Method1()
        {
            System.Console.WriteLine("MyDelegate");
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}