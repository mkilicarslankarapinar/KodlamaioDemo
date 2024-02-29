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
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Add(Instructor entity)
        {
            _instructorDal.Add(entity);
        }

        public void Delete(Instructor entity)
        {
            _instructorDal.Delete(entity);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _instructorDal.Get();
        }

        public void Update(Instructor entity)
        {
            _instructorDal.Update(entity);
        }
    }
}
