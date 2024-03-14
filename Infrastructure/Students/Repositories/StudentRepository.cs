using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Students.Repositories
{
        public class StudentRepository : IStudentRepository
    {
        private List<StudentEntity> _students = new List<StudentEntity>
            {
                new StudentEntity { Id =1, Name = "Asmae", Age =30 },
                new StudentEntity { Id =1, Name = "Asmae", Age =22 },
                new StudentEntity { Id =1, Name = "Asmae", Age =22 },
                new StudentEntity { Id =1, Name = "Asmae", Age =23 },

            };

       public  bool CreateStudent(StudentEntity student, CancellationToken cancellationtoken)
        {
            _students.Add(student);
            return true;
        }

       public List<StudentEntity> GetAll(CancellationToken cancellationtoken)
        {
            return _students;
        }
    }
}
