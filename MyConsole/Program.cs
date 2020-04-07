using System;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var mysub = new MySubClass().Name;
        }
    }

    public abstract class TestAbstract
    {
        public string Name;

        public virtual void DoSomething() 
        {
            // do  something here
        }
    }

    public class MySubClass: TestAbstract 
    {
        public  override void DoSomething() 
        {
            // do something here
        }
    }

}
