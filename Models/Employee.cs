using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2__Dimensions_Data.Models
{
    public partial class Employee
    {
        public int EmpNumber { get; set; }
        public int PayId { get; set; }
        
        public int EmpHistoryId { get; set; }
        public int EducationId { get; set; }
        public int SurveyId { get; set; }
        public int PerformanceId { get; set; }
        public int JobId { get; set; }

        public virtual EmployeeDetails Emp { get; set; }
        public virtual EmployeeEduaction Education { get; set; }
        public virtual EmployeeHistory EmpHistory { get; set; }
        public virtual EmployeePerformance Performance { get; set; }
        public virtual JobInformation Job { get; set; }
        public virtual CostToCompany Pay { get; set; }
        public virtual Survey Survey { get; set; }



    }
}
