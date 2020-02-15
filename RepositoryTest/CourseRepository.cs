using RepositoryTest.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryTest
{
    public class CourseRepository : IRepository<Course, string>
    {
        private List<Course> _courses = new List<Course>();

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Course Get(string id)
        {
            return _courses.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Course> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Course item)
        {
            _courses.Add(item);
        }
    }
}
