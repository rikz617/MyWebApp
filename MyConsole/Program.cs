﻿using System;

namespace MyConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //var mysub = new MySubClass().Name;
            //new HashSetSample().SampleMethod();
            //InterfacesSample interfaceSample = new InterfacesSample();

            //new HashSetSample().SampleMethod();

            //ThreadCreationProgram.Run();
           new Singleton().PrintDetails("Hello");
            

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
