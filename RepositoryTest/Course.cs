using RepositoryTest.Contracts;

namespace RepositoryTest
{
    public class Course : IStoreable<string>
    {
        public string Id { get; set; }
        public int LengthInWeeks { get; set; }
    }
}
