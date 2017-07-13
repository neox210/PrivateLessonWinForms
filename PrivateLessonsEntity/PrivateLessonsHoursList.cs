using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateLessonsEntity
{
    class PrivateLessonsHoursList
    {
        public List<PrivateLessonHour> PrivateLessonsList { get; set; }

        public PrivateLessonsHoursList(int studentId, bool showByDate, DateTime Date)
        {
            if (showByDate == true)
            {
                using (var DB = new PrivateLessonsEntities())
                {
                    PrivateLessonsList = DB.PrivateLessonHour
                                                            .Where(d => d.StartDate.Day == Date.Day && 
                                                                    d.StartDate.Month == Date.Month &&
                                                                    d.StartDate.Year == Date.Year)
                                                            .Where(s => s.StudentId == studentId)
                                                            .ToList();
                }
            }
            else
            {
                using (var DB = new PrivateLessonsEntities() )
                {
                    PrivateLessonsList = DB.PrivateLessonHour.Where(s => s.StudentId == studentId).ToList();
                }
            }
        }

        public PrivateLessonsHoursList(DateTime Date, bool showByStudent, int studentId)
        {
            if (showByStudent==true)
            {
                using (var DB = new PrivateLessonsEntities())
                {
                    PrivateLessonsList = DB.PrivateLessonHour
                                                            .Where(d => d.StartDate.Day == Date.Day &&
                                                                    d.StartDate.Month == Date.Month &&
                                                                    d.StartDate.Year == Date.Year)
                                                            .Where(s => s.StudentId == studentId)
                                                            .ToList();
                }
                    
            }
            else
            {
                using (var DB = new PrivateLessonsEntities())
                {
                    PrivateLessonsList = DB.PrivateLessonHour.Where(d => d.StartDate.Day == Date.Day &&
                                                                    d.StartDate.Month == Date.Month &&
                                                                    d.StartDate.Year == Date.Year)
                                                              .ToList();
                }
            }
        }
    }
}
