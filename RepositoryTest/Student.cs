using RepositoryTest.Contracts;

namespace RepositoryTest
{
    public class Student : IStoreable<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
