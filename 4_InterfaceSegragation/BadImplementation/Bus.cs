using System;
using System.Collections.Generic;
using System.Text;

namespace _4_InterfaceSegragation.BadImplementation
{
    public class Bus : IVehicle
    {
        public void accelerate()
        {

        }
        public void applyBrakes()
        {

        }
        public void fly()
        {
            //dummy implementation
            throw new NotImplementedException();
        }
    }
}
