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
            var existingCourse = _courses.FirstOrDefault(s => s.Id == id);
            if (existingCourse != null)
            {
                _courses.Remove(existingCourse);
            }
        }

        public Course Get(string id)
        {
            return _courses.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Course> GetAll()
        {
            return _courses;
        }

        public void Save(Course item)
        {
            var existingCourse = _courses.FirstOrDefault(s => s.Id == item.Id);
            if (existingCourse == null)
            {
                _courses.Add(item);
            }
            else
            {
                existingCourse.LengthInWeeks = item.LengthInWeeks;
            }
        }
    }
}
