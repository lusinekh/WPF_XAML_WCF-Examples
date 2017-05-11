using System.Collections.Generic;

[ServiceContract]
interface ISaleService
{
    [OperationContract]
    bool InsertCustomer(Customer obj);

    [OperationContract]
    List<Customer> GetAllCustomer();

    [OperationContract]
    bool DeleteCustomer(int Cid);

    [OperationContract]
    bool UpdateCustomer(Customer obj);
}

[DataContract]
public class Customer
{
    [DataMember]
    public int CustomerID;
    [DataMember]
    public string CustomerName;
    [DataMember]
    public string Address;
    [DataMember]
    public string EmailId;
}