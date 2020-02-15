using RepositoryTest.Contracts;

namespace RepositoryTest
{
    public class StringIdEntity : IStoreable<string>
    {
        public string Id { get; set; }
    }
}
