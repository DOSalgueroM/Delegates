using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates

{
    delegate int MathOperation(int a, int b);
    class DelegateExample
    {
        public static int Add(int a, int b)
        {
            int result =  a + b;
            
            return result;
        }

        public static int Subtract(int a, int b)
        {
            int result = a - b;
            
            return result;
        }
    }
}
