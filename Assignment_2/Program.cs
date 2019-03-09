using System;
//---------- Nirmal Patel------- C0730194-------
//-----------Harpreet Singh------C0727128-------
namespace C073084_Satinder_CSD3354_1_MARCH_6
{
    public class Program
    {
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
        }
    }
    public delegate int MyDelegate(out int i);

    public class DelegateExercises
    {
        int Method1(out int i)
        {
            i = 100;
            System.Console.WriteLine("Method1 " + i);
            return 0;
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            MyDelegate myDelegate1 = null;
            MyDelegate myDelegate2 = myDelegate + myDelegate1;
            int intValue;
            myDelegate2(out intValue);
        }
    }

}