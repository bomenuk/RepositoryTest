using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryTest.Tests
{
    public class StringIdEntityTests
    {
        [Test]
        public void Can_Assign_IntegerId_To_Entity()
        {
            var entity = new stringIdEntity();
            entity.Id = "abc";

            Assert.AreEqual(entity.Id, "abc");
        }
    }
}
