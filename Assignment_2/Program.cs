using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------- Nirmal Patel------- C0730194-------
//-----------Harpreet Singh------C0727128-------
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExercises de = new DelegateExercises();
            de.Method2();
            de.Method2(50);
        }
    }
    public class DelegateExercises
    {
        public delegate void MyDelegate();
        public void Method1()
        public delegate void MyDelegate(int i);
        public void Method1(int i)
        {
            Console.WriteLine("Method1");
            Console.WriteLine(i);
            Console.ReadLine();
        }
        public void Method2()
        public void Method2(int i)
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
            myDelegate(50);
        }
    }
}