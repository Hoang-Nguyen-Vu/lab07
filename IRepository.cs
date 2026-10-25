//Hoàng Nguyên Vũ
//202419020
namespace DeviceManagement
{
    public interface IRepository<T> where T : IIdentifiable
    {
        void Add(T item);
        bool Remove(string id);
        T? FindById(string id);
        IReadOnlyList<T> GetAll();
        IReadOnlyList<T> FindAll(Predicate<T> condition);
    }
}