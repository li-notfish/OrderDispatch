namespace OrderDispatch.WebApi.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<bool> CreateAsync(T entity);

        Task<T> GetAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<bool> UpdateAsync(T entity);

        Task<bool> DeleteAsync(int id);
    }
}
