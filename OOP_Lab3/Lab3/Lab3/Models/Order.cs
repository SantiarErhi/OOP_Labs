using Lab3.Models;
using System;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace Lab3
{
    [DataContract]
    class Order :  IService<Dish>, ICloneable
    {
        [DataMember]
        public DateTime createOrderTime { get; set; }
        [DataMember]
        public string cafeName { get; set; }
        [DataMember]
        ObservableCollection<Dish> _dishes { get; set; }
        [DataMember]
        public ObservableCollection<Dish>Dishes
        {
            get
            {
                return _dishes;
            }
            set
            {
                _dishes = value;
            }
        }

        public Order(DateTime createOrderTime, string cafeName, ObservableCollection<Dish> dishes)
        {
            this.createOrderTime = createOrderTime;
            this.cafeName = cafeName;
            _dishes = dishes;
          
        }

        public void Add(Dish dish)
        {
            _dishes.Add(dish);
        }

        public void Remove(int index)
        {
            _dishes.RemoveAt(index);
        }

        public object Clone()
        {
            ObservableCollection<Dish> dishes = new ObservableCollection<Dish>();
            foreach(var dish in Dishes)
            {
                dishes.Add(dish);
            }
            return new Order(createOrderTime, cafeName, dishes);
        }
    }
}
