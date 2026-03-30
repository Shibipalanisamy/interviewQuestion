using System;
using System.Collections.Generic;
using System.Text;

namespace Partices.Basic
{
    public class refandout
    {
        public int addnumber(ref int a,out int b)
        {
            b = 10; // if we delete the b value then we will get the error message and B=10 value retrun on out value
            return a + b;
        }
    }
}
