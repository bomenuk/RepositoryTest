using NUnit.Framework;

namespace RepositoryTest.Tests
{
    public class StringIdEntityTests
    {
        [Test]
        public void Can_Assign_IntegerId_To_Entity()
        {
            var entity = new StringIdEntity();
            entity.Id = "abc";

            Assert.AreEqual(entity.Id, "abc");
        }
    }
}
