namespace Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll(int page, int pageSize);

        Task<T> GetById(int id);

        Task<int> Insert(T obj);

        Task<int> Update(T obj);

        Task<int> Delete(int id);
    }
}