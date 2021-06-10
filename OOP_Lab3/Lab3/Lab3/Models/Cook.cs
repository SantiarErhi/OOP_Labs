using System.Runtime.Serialization;

namespace Lab3
{
    [DataContract]
    class Cook
    {
        [DataMember]
        string name { get; set; }
        [DataMember]
        string surname { get; set; }
        public Cook(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public override string ToString()
        {
            return $"{name} {surname}";
        }
    }
}
