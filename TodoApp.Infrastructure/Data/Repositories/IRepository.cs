namespace TodoApp.Infrastructure.Data.Repositories;

public interface IRepository<T>
{
    Task AddAsync(T item);
    Task<T> GetAsync(Guid id);
    Task<T> FindbyAsync(string value);
    Task<IEnumerable<T>> AllAsync();
    Task SaveChangesAsync();

}
