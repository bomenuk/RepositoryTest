using NUnit.Framework;

namespace RepositoryTest.Tests
{
    public class Tests
    {
        [Test]
        public void Can_Assign_IntegerId_To_Entity()
        {
            var entity = new IntIdEntity();
            entity.Id = 123;

            Assert.AreEqual(entity.Id, 123);
        }
    }
}