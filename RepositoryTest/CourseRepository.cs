using RepositoryTest.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryTest
{
    public class CourseRepository : IRepository<Course, string>
    {
        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Course Get(string id)
        {
            return new Course { Id = "Math", LengthInWeeks = 4 };
        }

        public IEnumerable<Course> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Course item)
        {
            throw new NotImplementedException();
        }
    }
}
