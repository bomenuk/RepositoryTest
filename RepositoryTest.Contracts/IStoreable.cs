namespace RepositoryTest.Contracts
{
    public interface IStoreable<T>
    {
        T Id { get; set; }
    }
    
}