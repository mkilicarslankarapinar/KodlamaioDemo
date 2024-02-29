using Business.Abstracts;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course entity)
        {
            _courseDal.Add(entity);
        }

        public void Delete(Course entity)
        {
            _courseDal.Delete(entity);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public Course GetById(int id)
        {
            return _courseDal.Get();
        }

        public void Update(Course entity)
        {
            _courseDal.Update(entity);
        }
    }
}
