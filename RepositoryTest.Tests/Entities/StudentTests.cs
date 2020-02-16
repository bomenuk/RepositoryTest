using NUnit.Framework;
using RepositoryTest.Entities;

namespace RepositoryTest.Tests.Entities
{
    public class StudentTests
    {
        [Test]
        public void Can_Assign_IntegerId_To_Entity()
        {
            var student = new Student();
            student.Id = 1;
            student.Name = "John";

            Assert.AreEqual(student.Id, 1);
            Assert.AreEqual(student.Name, "John");
        }
    }
}