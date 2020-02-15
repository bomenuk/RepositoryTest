using RepositoryTest.Contracts;

namespace RepositoryTest
{
    public class IntIdEntity : IStoreable<int>
    {
        public int Id { get; set; }
    }
}
