using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment
{
    internal class TrainingSchedule
    {
      
            public List<string> ScheduleList { get; set; }

         
            public TrainingSchedule()
            {
                ScheduleList = new List<string>();
            }

            
            public void ViewSchedules(DateTime date, User user)
            {
                // Implementation 
            }

            public void AddSchedule(string newSchedule)
            {
                // Implementation 
            }

            public void DeleteSchedule(string schedule)
            {
                // Implementation 
            }

            public void EditSchedule(string oldSchedule, string newSchedule)
            {
                // Implementation 
        }

    }
}
