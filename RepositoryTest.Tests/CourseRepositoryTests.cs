﻿using NUnit.Framework;

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

        [Test]
        public void Get_Should_Return_Correct_Record_After_Add_1_Record()
        {
            var course = new Course() { Id = "Math", LengthInWeeks = 4 };
            courseRepository.Save(course);
            var result = courseRepository.Get("Math");
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Id, "Math");
            Assert.AreEqual(result.LengthInWeeks, 4);
        }

        [Test]
        public void Get_Should_Return_Correct_Record_After_Add_2_Records()
        {
            var course = new Course() { Id = "Math", LengthInWeeks = 4 };
            courseRepository.Save(course);
            var result = courseRepository.Get("Math");
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Id, "Math");
            Assert.AreEqual(result.LengthInWeeks, 4);

            course = new Course() { Id = "PE", LengthInWeeks = 12 };
            courseRepository.Save(course);
            result = courseRepository.Get("PE");
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Id, "PE");
            Assert.AreEqual(result.LengthInWeeks, 12);
        }
    }
}
