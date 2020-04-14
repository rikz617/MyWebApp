using MyConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsole
{
    public class Animal : IAnimal
    {
        public void Jump()
        {

        }

        public void Eat()
        {

        }

       
    }



    public class Dog : IAnimal
    {
        public void Bark()
        {

        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Jump()
        {
            throw new NotImplementedException();
        }
    }

    public class Cat : IAnimal
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Jump()
        {
            throw new NotImplementedException();
        }

        public void Meow()
        {

        }

    }
}
