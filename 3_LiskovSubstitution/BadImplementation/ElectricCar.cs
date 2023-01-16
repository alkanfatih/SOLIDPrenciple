using System;
using System.Collections.Generic;
using System.Text;

namespace _3_LiskovSubstitution.BadImplementation
{
    public class ElectricCar: Car
    {
        public override void fuel()
        {
            throw new Exception("Not Supported");
        }
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
