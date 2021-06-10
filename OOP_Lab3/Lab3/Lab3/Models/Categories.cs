using System.Runtime.Serialization;

namespace Lab3
{
    [DataContract]
    enum Categories
    {
        [EnumMember]
        ColdSnacks,
        [EnumMember]
        FirstMeal,
        [EnumMember]
        SecondMeal,
        [EnumMember]
        Desserts,
        [EnumMember]
        Drinks
    }
}
