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
            de.Method3(10);
            Console.Read();
        }
    }

    public class DelegateExercises
    {
        public delegate int MyDelegate(int i);
        public int Method1(int intMethod1)
        {
            return intMethod1 * 4;
        }
        public int Method2(int intMethod1)
        {
            return intMethod1 * 20;
        }
        public void Method4(MyDelegate myDelegate)
        {
            for (int i = 1; i <= 5; i++)
                System.Console.Write(myDelegate(i) + " ");
        }
        public void Method3(int intMethod3)
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            Method4(myDelegate);
            myDelegate = new MyDelegate(Method2);
            Method4(myDelegate);
        }
    }
}