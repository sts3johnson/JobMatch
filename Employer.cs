using System;

namespace JobMatch
{
    /// <summary>
    /// Creates methods for IEmployer
    /// </summary>
    public class Employer : IEmployer
    {
        /// <summary>
        /// Gets or sets the employer id.
        /// </summary>
        public int _EmployerID { get; set; }

        /// <summary>
        /// Gets or sets the employer name.
        /// </summary>
        public string _EmployerName { get; set; }

        /// <summary>
        /// Gets or sets the job offer title.
        /// </summary>
        public string _JobOfferTitle { get; set; }

        /// <summary>
        /// Gets or sets the job requirments.
        /// </summary>
        public string _JobRequirments { get; set; }

        private Tuple<int, string, string, string> EmployerOffer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Employer"/> class.
        /// </summary>
        public Employer()
        {
        }

        /// <summary>
        /// Adds the id.
        /// </summary>
        /// <param name="id">The id.</param>
        public void AddId(int id)
        {
            _EmployerID = id;
        }

        /// <summary>
        /// Adds the name.
        /// </summary>
        /// <param name="name">The name.</param>
        public void AddName(string name)
        {
            _EmployerName = name;
        }

        /// <summary>
        /// Adds the title.
        /// </summary>
        /// <param name="title">The title.</param>
        public void AddTitle(string title)
        {
            _JobOfferTitle = title;
        }

        /// <summary>
        /// Adds the requirments.
        /// </summary>
        /// <param name="requirments">The requirments.</param>
        public void AddRequirments(string requirments)
        {
            _JobRequirments = requirments;
        }

        /// <summary>
        /// Creates method for implamentation
        /// </summary>
        /// <returns>A (int, string, string, string) .</returns>

        public Tuple<int, string, string, string> _DisplayAllEmployerInfo()
        {
            EmployerOffer = new Tuple<int, string, string, string>(_EmployerID, _EmployerName, _JobOfferTitle, _JobRequirments); ;

            return EmployerOffer;
        }
    }
}