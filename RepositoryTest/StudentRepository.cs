using RepositoryTest.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryTest
{
    public class StudentRepository : IRepository<Student, int>
    {
        private List<Student> _students = new List<Student>();

        public void Delete(int id)
        {
            
        }

        public Student Get(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Student item)
        {
            var existingStudent = _students.FirstOrDefault(s => s.Id == item.Id);
            if(existingStudent==null)
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
