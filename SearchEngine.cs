using System;
using System.Collections.Generic;
namespace JobMatch
{
    /// <summary>
    /// Compares Employee prefered Job with Employer Job Title
    /// </summary>
    public class SearchEngine
    {
        private Tuple<int, string, string, string> MatchFound;
        private readonly IList<IEmployee> _employees;
        private readonly IList<IEmployer> _employers;
        public SearchEngine()
        {
            _employers = new List<IEmployer>();
            _employees = new List<IEmployee>();
        }

        /// <summary>
        /// Adds the employee info.
        /// Expected input is userId, SearchTitle
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <param name="employeeInfo">The employee info.</param>
        public void AddEmployeeInfo(IEmployee employee, (int, string) employeeInfo)
        {
            //TODO refactor employee set methods into one
            employee.AddUserId(employeeInfo.Item1);
            employee.AddSearchTitle(employeeInfo.Item2);
            _employees.Add(employee);
        }

        /// <summary>
        /// Adds the employer info.
        /// _EmployerID, _EmployerName, _JobOfferTitle, _JobRequirments
        /// expected input
        /// </summary>
        /// <param name="employer">The employer.</param>
        /// <param name="employerInfo">The employer info.</param>
        public void AddEmployerInfo(IEmployer employer, (int, string, string, string) employerInfo)
        {
            //TODO refactor employer set methods into one
            employer.AddId(employerInfo.Item1);
            employer.AddName(employerInfo.Item2);
            employer.AddTitle(employerInfo.Item3);
            employer.AddRequirments(employerInfo.Item4);
            _employers.Add(employer);
        }

        /// <summary>
        /// Useful for local testing/testing
        /// </summary>
        /// <returns>A Tuple.</returns>
        public Tuple<int, string, string, string> PerformSearch()
        {
            try
            {
                string EmployerTitle = GetEmployerJobTitle();
                string EmployeeTitle = GetEmployeeJobTitle();
                if (EmployerTitle.Contains(EmployeeTitle))
                {
                    foreach (var item in _employers)
                    {
                        MatchFound = item._DisplayAllEmployerInfo();
                    }
                }

                if (MatchFound != null) { return MatchFound; }
                else
                {
                    throw new Exception("Match not found...");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }
        //TODO create a performsearch on a db and return employer jobs matching search of employee

        /// <summary>
        /// Gets the employee job title.
        /// </summary>
        /// <returns>A string.</returns>
        private string GetEmployeeJobTitle()
        {
            string tempTitle = "";
            foreach (var employeeSearch in _employees)
            {
                tempTitle = employeeSearch._JobSearchTitle;
            }
            return tempTitle;
        }

        /// <summary>
        /// Gets the employer job title.
        /// </summary>
        /// <returns>A string.</returns>
        private string GetEmployerJobTitle()
        {
            string tempTitle = "";
            foreach (var employerTitle in _employers)
            {
                tempTitle = employerTitle._JobOfferTitle;
            }
            return tempTitle;
        }
    }
}