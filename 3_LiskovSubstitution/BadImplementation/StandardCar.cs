using System;
using System.Collections.Generic;
using System.Text;

namespace _3_LiskovSubstitution.BadImplementation
{
    public class StandardCar: Car
    {
        public override void fuel()
        {
            //...
            base.fuel();
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
