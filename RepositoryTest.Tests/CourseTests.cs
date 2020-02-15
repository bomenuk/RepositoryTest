using NUnit.Framework;

namespace RepositoryTest.Tests
{
    public class CourseTests
    {
        [Test]
        public void Can_Assign_IntegerId_To_Entity()
        {
            var entity = new Course();
            entity.Id = "Biology";

            Assert.AreEqual(entity.Id, "Biology");
        }
    }
}
