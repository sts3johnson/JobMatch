using System;

namespace JobMatch
{
   
    public class Start
    {
        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args">The args.</param>
        /// <returns>An int.</returns>
        static int Main(string[] args)
        {
            SearchEngine searchEngine = new SearchEngine();
            searchEngine.AddEmployeeInfo(new Employee(), (2, "dev"));
            searchEngine.AddEmployerInfo(new Employer(), (12, "Wal-Mart", "python", "4 years of xp"));
            searchEngine.AddEmployerInfo(new Employer(), (12, "Google", ".Net dev", "4 years of xp"));
            var results = searchEngine.PerformSearch();
            Console.WriteLine(results);
            Console.ReadKey();
            return 0;
        }
    }
}
