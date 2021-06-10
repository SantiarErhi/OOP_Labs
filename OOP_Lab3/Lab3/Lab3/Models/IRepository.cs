using System.Collections.ObjectModel;

namespace Lab3.Models
{
    interface IRepository
    {
        public ObservableCollection<Order> LoadFrom(string filePath);
        public void SaveTo(ObservableCollection<Order> orders, string filePath);
        
    }
}
