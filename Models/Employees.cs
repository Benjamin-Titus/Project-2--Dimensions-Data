
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project_2__Dimensions_Data.Models
{
    public partial class Employees
    {
       [Key]
        public int Id { get; set; }
        public int PayId { get; set; }
        public int EmpHistoryId { get; set; }
        public int EducationId { get; set; }
        public int SurveyId { get; set; }
        public int PerformanceId { get; set; }
        public int JobId { get; set; }

       
        public int EmployeeNumber { get; set; }
        public int Age { get; set; }
        public string Attrition { get; set; }

        [Display(Name ="Business Travel")]
        public string BusinessTravel { get; set; }

        [Display(Name = "Daily Rate")]
        public int DailyRate { get; set; }

        [Display(Name = "Department")]
        public string Department { get; set; }

        [Display(Name = "Distance From Home")]
        public int DistanceFromHome { get; set; }

        [Display(Name = "Education")]
        public int Education { get; set; }

        [Display(Name = "Education Field")]
        public string EducationField { get; set; }

        [Display(Name = "Employee Count")]
        public int EmployeeCount { get; set; }

        [Display(Name = "Environment Satisfaction")]
        public int EnvironmentSatisfaction { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Hourly Rate")]
        public int HourlyRate { get; set; }

        [Display(Name = "Job Involvement")]
        public int JobInvolvement { get; set; }

        [Display(Name = "Job Level")]
        public int JobLevel { get; set; }

        [Display(Name = "Job Role")]
        public string JobRole { get; set; }

        [Display(Name = "Job Satisfaction")]
        public int JobSatisfaction { get; set; }

        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }

        [Display(Name = "Monthly Income")]
        public int MonthlyIncome { get; set; }

        [Display(Name = "Monthly Rate")]
        public int MonthlyRate { get; set; }

        [Display(Name = "Number of Companies Worked")]
        public int NumCompaniesWorked { get; set; }

        [Display(Name = "Over18")]
        public string Over18 { get; set; }

        [Display(Name = "Overtime")]
        public string OverTime { get; set; }

        [Display(Name = "Percentage Salary Hike")]
        public int PercentSalaryHike { get; set; }

        [Display(Name = "Perfomance Rating")]
        public int PerformanceRating { get; set; }

        [Display(Name = "Relationship Satisfaction")]
        public int RelationshipSatisfaction { get; set; }

        [Display(Name = "Standard Hour")]
        public int StandardHours { get; set; }

        [Display(Name = "Stock Option Level")]
        public int StockOptionLevel { get; set; }

        [Display(Name = "Total Working Years")]
        public int TotalWorkingYears { get; set; }

        [Display(Name = "Training Times Last Year")]
        public int TrainingTimesLastYear { get; set; }

        [Display(Name = "Work Life Balance")]
        public int WorkLifeBalance { get; set; }

        [Display(Name = "Years at Company")]
        public int YearsAtCompany { get; set; }

        [Display(Name = "Years In Current Role")]
        public int YearsInCurrentRole { get; set; }

        [Display(Name = "Years Since Last Promotion")]
        public int YearsSinceLastPromotion { get; set; }

        [Display(Name = "Years With Curr Manager")]
        public int YearsWithCurrManager { get; set; }

    }
}
