using System;

namespace JobMatch
{
    public interface IEmployer
    {
        int _EmployerID { get; set; }
        string _EmployerName { get; set; }
        string _JobOfferTitle { get; set; }
        string _JobRequirments { get; set; }

        void AddId(int id);
        void AddName(string name);
        void AddRequirments(string requirments);
        void AddTitle(string title);
        Tuple<int, string, string, string> _DisplayAllEmployerInfo();
    }
}