using System;
using System.Collections.Generic;
using System.Text;

namespace _3_LiskovSubstitution.GodImplementation
{
    public class ElectricCar: Car
    {
        public override void wheels()
        {
            //...
            base.wheels();
        }
        public override void run()
        {
            //...
            base.run();
        }
    }
}
