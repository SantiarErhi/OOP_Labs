using System.Runtime.Serialization;

namespace Lab3
{
    [DataContract]
    class Dish
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int cost { get; set; }
        [DataMember]
        public int timeToReady { get; set; }
        [DataMember]
        public Cook cook { get; set; }
        [DataMember]
        public Categories categories { get; set; }

        public Dish(string name, int cost, int timeToReady, Cook cook, Categories categories)
        {
            this.name = name;
            this.cost = cost;
            this.timeToReady = timeToReady;
            this.cook = cook;
            this.categories = categories;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public string ToShortString()
        {
            return $"Name: {name}" +
                $"Cost: {cost}";
        }
    }
}
