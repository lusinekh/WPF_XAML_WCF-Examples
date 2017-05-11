using System.Collections.Generic;
using System.ServiceModel;

namespace WcfServiceLibrary5
{
    [ServiceContract]
    public interface IBetService
    {
        [OperationContract]
        string GetValue(int i);

        [OperationContract]
        List<double> CalculateSin(double[] x);

        [OperationContract]
        List<Person> GetPersons();
    }
}