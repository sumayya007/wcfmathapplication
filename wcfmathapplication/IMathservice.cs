using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfmathapplication
{
    
    [ServiceContract]
    public interface IMathservice
    {
        [OperationContract]
        Int32 Add(Int32 num1,Int32 num2);

        [OperationContract]
        Int32 Subtract(Int32 num1, Int32 num2);

        [OperationContract]
        Int32 Multiply(Int32 num1, Int32 num2);

        [OperationContract]
        Int32 Devide(Int32 num1, Int32 num2);
    }
}
