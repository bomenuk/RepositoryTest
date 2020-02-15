using RepositoryTest.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryTest
{
    public class StudentRepository : IRepository<Student, int>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Student item)
        {
            throw new NotImplementedException();
        }
    }
}
