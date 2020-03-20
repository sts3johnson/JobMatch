namespace JobMatch
{
    public interface IEmployee
    {
        string _JobSearchTitle { get; set; }
        int _UserId { get; set; }

        void AcceptOrDeclineJob(int select);
        void AddSearchTitle(string title);
        void AddUserId(int id);
    }
}