using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateInvocationProgram
{
    class Program
    {
        static double Calculate(int x, double y) { return x + y; }

        void Update(int newNumber) { System.Console.WriteLine(newNumber); }

        void Delete(string key) { }

        void ArgumentMethod4() { }
        int ArgumentMethod5(int data) { return data; }
        bool ArgumentMethod6(string data1, string data2) { return true; }

        static void FunctionsAsAnArguments(Func<int, double, double> obj1, Action<int> obj2, Action<string> obj3, Action obj4, Func<int, int> obj5, Func<string, string, bool> obj6)
        {
            double parameter= obj1.Invoke(5,5.2);
            obj2.Invoke(12);
            obj3.Invoke("string");
            obj4.Invoke();
            int intparameter= obj5.Invoke(10);
            bool result= obj6.Invoke("data1","data2");
            Console.WriteLine(parameter);
            Console.WriteLine(intparameter);
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            Program _instance = new Program();
            Func<int, double, double> obj1Object = new Func<int, double, double>(Calculate);
            Action<int> obj2Object = new Action<int>(_instance.Update);
            Action<string> obj3Object = new Action<string>(_instance.Delete);
            Action obj4Object = new Action(_instance.ArgumentMethod4);
            Func<int, int> obj5Object = new Func<int, int>(_instance.ArgumentMethod5);
            Func<string, string, bool> obj6Object = new Func<string, string, bool>(_instance.ArgumentMethod6);

            FunctionsAsAnArguments(obj1Object, obj2Object, obj3Object, obj4Object, obj5Object, obj6Object);
        }
    }
 
}
