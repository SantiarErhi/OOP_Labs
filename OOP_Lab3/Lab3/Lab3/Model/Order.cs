using System;
using System.Collections.Generic;

namespace Lab3
{
    class Order
    {
        DateTime createOrderTime { get; set; }
        string cafeName { get; set; }
        DateTime currentDate { get; set; }
        List<Dish> dishes = new List<Dish>();

        public Order(DateTime createOrderTime, string cafe, DateTime currentDate)
        {
            this.createOrderTime = createOrderTime;
            this.cafeName = cafe;
            this.currentDate = currentDate;
            
        }
        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }
    }
}
