using NUnit.Framework;

namespace RepositoryTest.Tests
{
    public class CourseTests
    {
        [Test]
        public void Can_Assign_IntegerId_To_Entity()
        {
            var course = new Course();
            course.Id = "Biology";

            Assert.AreEqual(course.Id, "Biology");
        }
    }
}
