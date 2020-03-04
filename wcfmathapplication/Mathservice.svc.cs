using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfmathapplication
{
   
    public class Mathservice : IMathservice
    {
        public Int32 Add(Int32 num1,Int32 num2)
        {
            return num1 + num2;
        }

        public Int32 Subtract(Int32 num1, Int32 num2)
        {
            Int32 result = 0;
            if (num1 > num2)
            {
                result= num1 - num2;
            }
            else if (num2 > num1)
            {
                result= num2 - num1;
            }
            return result;
        }

        public Int32 Multiply(Int32 num1, Int32 num2)
        {
            return num1 * num2;
        }

        public Int32 Devide(Int32 num1, Int32 num2)
        {
            return num1 / num2;
        }
    }
}
