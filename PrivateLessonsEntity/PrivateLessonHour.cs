using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateLessonsEntity
{
    public class PrivateLessonHour
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsHome { get; set; }
        public string Subject { get; set; }
        public string Topic { get; set; }
        public string Comment { get; set; }
        public string HourDescription { get; set; }
        public string HourDescriptionSchedule { get; set; }

    }
}
