using NUnit.Framework;

namespace RepositoryTest.Tests
{
    public class CourseRepositoryTests
    {
        CourseRepository courseRepository = null;

        [SetUp]
        public void Setup()
        {
            courseRepository = new CourseRepository();
        }

        [Test]
        public void Get_Should_Return_Null_When_No_Records()
        {
            var result = courseRepository.Get("math");
            Assert.IsNull(result);
        }

        
    }
}
