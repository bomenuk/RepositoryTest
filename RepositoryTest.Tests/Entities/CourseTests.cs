﻿using NUnit.Framework;
using RepositoryTest.Entities;

namespace RepositoryTest.Tests.Entities
{
    public class CourseTests
    {
        [Test]
        public void Can_Assign_StringId_To_Entity()
        {
            var course = new Course();
            course.Id = "Biology";
            course.LengthInWeeks = 20;

            Assert.AreEqual(course.Id, "Biology");
            Assert.AreEqual(course.LengthInWeeks, 20);
        }
    }
}
