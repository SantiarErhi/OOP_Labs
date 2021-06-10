namespace Lab3.Models
{
    interface IService<T>
    {
        public void Add(T t);
        public void Remove(int index);
    }
}
