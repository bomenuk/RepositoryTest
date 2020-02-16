using RepositoryTest.Contracts;

namespace RepositoryTest.Entities
{
    public class Student : IStoreable<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
