using NUnit.Framework;
using System.Linq;

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

        [Test]
        public void Save_Should_Add_Record_Into_Repository_When_Its_New()
        {
            var course = new Course() { Id = "Math", LengthInWeeks = 10 };
            courseRepository.Save(course);
            var result = courseRepository.Get("Math");
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Id, "Math");
            Assert.AreEqual(result.LengthInWeeks, 10);
        }

        [Test]
        public void Save_Should_Update_Record_Into_Repository_When_Exist()
        {
            var course = new Course() { Id = "Math", LengthInWeeks = 10 };
            courseRepository.Save(course);
            var result = courseRepository.Get("Math");
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Id, "Math");
            Assert.AreEqual(result.LengthInWeeks, 10);

            course = new Course() { Id = "Math", LengthInWeeks = 8 };
            courseRepository.Save(course);
            result = courseRepository.Get("Math");
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Id, "Math");
            Assert.AreEqual(result.LengthInWeeks, 8);
        }

        [Test]
        public void Delete_Should_Do_Nothing_When_Record_Not_Exist()
        {
            var course = new Course() { Id = "Math", LengthInWeeks = 10 };
            courseRepository.Save(course);
            courseRepository.Delete("English");
            var result = courseRepository.Get("Math");
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Id, "Math");
            Assert.AreEqual(result.LengthInWeeks, 10);
        }

        [Test]
        public void Delete_Should_Remove_Record_From_Repository_When_Exist()
        {
            var course = new Course() { Id = "Math", LengthInWeeks = 10 };
            courseRepository.Save(course);
            var result = courseRepository.Get("Math");
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Id, "Math");
            Assert.AreEqual(result.LengthInWeeks, 10);

            courseRepository.Delete("Math");
            result = courseRepository.Get("Math");
            Assert.IsNull(result);
        }

        [Test]
        public void GetAll_Should_Return_EmptyList_When_No_Records()
        {
            var result = courseRepository.GetAll();
            Assert.IsEmpty(result);
        }

        [Test]
        public void GetAll_Should_Return_Correct_Result_After_Added_Records()
        {
            var course = new Course() { Id = "English", LengthInWeeks = 50 };
            courseRepository.Save(course);
            course = new Course() { Id = "History", LengthInWeeks = 20 };
            courseRepository.Save(course);
            var result = courseRepository.GetAll().ToList();
            Assert.IsNotEmpty(result);
            Assert.AreEqual(result.Count(), 2);
            Assert.AreEqual(result[0].Id, "English");
            Assert.AreEqual(result[0].LengthInWeeks, 50);
            Assert.AreEqual(result[1].Id, "History");
            Assert.AreEqual(result[1].LengthInWeeks, 20);

        }
    }
}
