using NUnit.Framework;
using System.Linq;

namespace RepositoryTest.Tests
{
    public class StudentRepositoryTests
    {
        StudentRepository studentRepository = null;

        [SetUp]
        public void Setup()
        {
            studentRepository = new StudentRepository();
        }

        [Test]
        public void Get_Should_Return_Null_When_No_Records()
        {
            var result = studentRepository.Get(1);
            Assert.IsNull(result);
        }

        [Test]
        public void Get_Should_Return_Correct_Record_After_Add_1_Record()
        {
            var student = new Student() { Id = 1, Name = "Amy" };
            studentRepository.Save(student);
            var result = studentRepository.Get(1);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Id, 1);
            Assert.AreEqual(result.Name, "Amy");
        }

        [Test]
        public void Save_Should_Add_Record_Into_Repository_When_Its_New()
        {
            var student = new Student() { Id = 1, Name = "Amy" };
            studentRepository.Save(student);
            var result = studentRepository.Get(1);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Id, 1);
            Assert.AreEqual(result.Name, "Amy");
        }

        [Test]
        public void Save_Should_Update_Record_Into_Repository_When_Exist()
        {
            var student = new Student() { Id = 1, Name = "Amy" };
            studentRepository.Save(student);
            var result = studentRepository.Get(1);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Id, 1);
            Assert.AreEqual(result.Name, "Amy");

            student = new Student() { Id = 1, Name = "Bob" };
            studentRepository.Save(student);
            result = studentRepository.Get(1);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Id, 1);
            Assert.AreEqual(result.Name, "Bob");
        }

        [Test]
        public void Delete_Should_Do_Nothing_When_Record_Not_Exist()
        {
            var student = new Student() { Id = 1, Name = "Amy" };
            studentRepository.Save(student);
            studentRepository.Delete(2);
            var result = studentRepository.Get(1);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Id, 1);
            Assert.AreEqual(result.Name, "Amy");
        }

        [Test]
        public void Delete_Should_Remove_Record_From_Repository_When_Exist()
        {
            var student = new Student() { Id = 1, Name = "Amy" };
            studentRepository.Save(student);
            var result = studentRepository.Get(1);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Id, 1);
            Assert.AreEqual(result.Name, "Amy");

            studentRepository.Delete(1);
            result = studentRepository.Get(1);
            Assert.IsNull(result);
        }        

        [Test]
        public void GetAll_Should_Return_EmptyList_When_No_Records()
        {
            var studentRepository = new StudentRepository();

            var result = studentRepository.GetAll();
            Assert.IsEmpty(result);
        }

        [Test]
        public void GetAll_Should_Return_Correct_Result_After_Added_Records()
        {
            var studentRepository = new StudentRepository();

            var student = new Student() { Id = 1, Name = "Amy" };
            studentRepository.Save(student);
            student = new Student() { Id = 2, Name = "Bob" };
            studentRepository.Save(student);
            var result = studentRepository.GetAll();
            Assert.IsNotEmpty(result);
            Assert.Equals(result.Count(), 2);
        }
    }
}
