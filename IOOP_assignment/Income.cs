using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment
{
    internal class Income
    {
        private decimal adminSalary; 
        private decimal coachSalary;

     
        public Income(decimal adminSalary, decimal coachSalary)
        {
            this.adminSalary = adminSalary;
            this.coachSalary = coachSalary;
        }


        public void ViewMonthlyIncome(User user)
            {
                // Implementation 
            }

         public void ViewSalaries(User user)
            {
                // Implementation
            }

         public void ViewFees(string role)
            {
                // Implementation 
            }

         public void Pay(string recipient, decimal amount)
            {
                // Implementation
            }
        

    }
}
