using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateLessonsEntity
{
    public class Students
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Level { get; set; }
        public int SchoolClass { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; }
        public string StudentDescription { get; set; }

        // public ICollection<PrivateLessonHour> PrivateLessons { get; set; }


    }
}
