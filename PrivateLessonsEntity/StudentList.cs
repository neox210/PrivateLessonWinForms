using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateLessonsEntity
{
    class StudentList
    {
        public List<Students> StudentsPickList { get; set; }

        public StudentList()
        {
            using (var StudentsDB = new PrivateLessonsEntities())
            {
                StudentsPickList=StudentsDB.Students.ToList();
            }
        }
    }
}
