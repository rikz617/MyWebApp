using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsole
{
    public class InterfacesSample: IHeroCanFly
    {
        public void SampleInterface() 
        {
            
        }

        public void Run() { }
        public void Walk() { }
        public void Fly() { }
        public void SpecialPower() { }

    }

    public interface IHeroRegular
    {
        void Run();
        void Walk();
    }

    public interface IHeroCanFly
    {
        void Fly();
    }

    public interface IHeroHybrid : IHeroRegular, IHeroCanFly
    {
        void SpecialPower();
    }

}
