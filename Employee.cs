using System;

namespace JobMatch
{
    /// <summary>
    /// Creates an employee
    /// </summary>
    public class Employee : IEmployee
    {
        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int _UserId { get; set; }

        /// <summary>
        /// Gets or sets the  job search title.
        /// </summary>
        public string _JobSearchTitle { get; set; }

        /// <summary>
        /// Accepts or decline job.
        /// </summary>
        /// <param name="select">The selection</param>
        public void AcceptOrDeclineJob(int select)
        {
            switch (select)
            {
                case 1:
                    Console.WriteLine("Congraulations your employer will email you...");
                    break;

                case 2:
                    Console.WriteLine("We will continue looking for more jobs as they become availiable for you.");
                    break;

                default:
                    break;
            }
        }

        public void AddUserId(int id)
        {
            _UserId = id;
        }

        public void AddSearchTitle(string title)
        {
            _JobSearchTitle = title;
        }
    }
}