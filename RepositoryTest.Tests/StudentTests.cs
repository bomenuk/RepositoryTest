using NUnit.Framework;

namespace RepositoryTest.Tests
{
    public class Tests
    {
        [Test]
        public void Can_Assign_IntegerId_To_Entity()
        {
            var student = new Student();
            student.Id = 1;

            Assert.AreEqual(student.Id, 123);
        }
    }
}