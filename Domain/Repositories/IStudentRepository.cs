using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IStudentRepository
    {
        // Methode qui renvoie une liste des etudiants 
        List<StudentEntity> GetAll(CancellationToken cancellationtoken );
        // Methode qui crée un nv etudiant et renvoie un booleen 
        bool CreateStudent(StudentEntity student , CancellationToken cancellationtoken);
    }
}
