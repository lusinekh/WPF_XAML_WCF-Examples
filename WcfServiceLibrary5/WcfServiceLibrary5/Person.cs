using System.Runtime.Serialization;

namespace WcfServiceLibrary5
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Age { get; set; }
    }
}