using System;
using System.Collections.Generic;
using System.Text;

namespace _3_LiskovSubstitution.BadImplementation
{
    public class Car
    {
        public virtual void fuel() { }
        public virtual void wheels() { }
        public virtual void run () { }
    }
}
