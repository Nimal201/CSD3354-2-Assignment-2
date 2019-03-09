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
        public static void Main(string[] args)
        {
            DelegateExercises de = new DelegateExercises();
            de.Method3();
            Console.Read();
        }
    }
    public delegate void MyDelegate();
    public class DelegateExercises
    {
        void Method1()
        {
            System.Console.WriteLine("Method1");
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }

}