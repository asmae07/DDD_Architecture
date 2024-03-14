using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Model
{
    public class StudentBase
    { public int Id { get; set; } }

    public class StudentModel : StudentBase
    { public string Name { get; set; } }

    public class StudentModel1 : StudentBase
    {  public int Age { get; set; } }

    public class Student : StudentBase
    {    public string Name { get; set; }
        public int Age { get; set; }
        public Student EntityToModel (StudentEntity student)
        {
            return new Student
            {
                Id = student.Id,
                Name = student.Name,
                Age = student.Age,
            };

        }
    }

}
