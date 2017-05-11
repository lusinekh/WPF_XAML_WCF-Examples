using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyWCFServices
{
    interface IHelloWorldService
    {
        [OperationContract]
        String GetMessage(String name);
    }
}
