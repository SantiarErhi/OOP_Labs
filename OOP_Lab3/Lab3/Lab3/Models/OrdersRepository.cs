using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;


namespace Lab3.Models
{
    class OrdersRepository : IRepository
    {
        public void SaveTo(ObservableCollection<Order> orders, string filePath)
        {
            var serializer = new DataContractSerializer(typeof(ObservableCollection<Order>));
            using (var writer = XmlWriter.Create(filePath))
            {
                serializer.WriteObject(writer, orders);
            }
        }

        public ObservableCollection<Order> LoadFrom(string filePath)
        {
            if (File.Exists(filePath))
            {
                var serializer = new DataContractSerializer(typeof(ObservableCollection<Order>));
                using (var reader = XmlReader.Create(filePath))
                {
                    var orders = (ObservableCollection<Order>)serializer.ReadObject(reader);
                    return orders;
                }
            }
            else
            {
                throw new Exception("File does not exists");
            }
        }
    }
}
