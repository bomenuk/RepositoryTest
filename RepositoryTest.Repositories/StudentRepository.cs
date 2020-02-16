using RepositoryTest.Contracts;
using RepositoryTest.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryTest.Repositories
{
    public class StudentRepository : IRepository<Student, int>
    {
        private List<Student> _students = new List<Student>();

        public void Delete(int id)
        {
            var existingStudent = _students.FirstOrDefault(s => s.Id == id);
            if (existingStudent != null)
            {
                _students.Remove(existingStudent);
            }
        }

        public Student Get(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        public void Save(Student item)
        {
            var existingStudent = _students.FirstOrDefault(s => s.Id == item.Id);
            if (existingStudent == null)
            {
                _students.Add(item);
            }
            else
            {
                existingStudent.Name = item.Name;
            }
        }
    }
}
