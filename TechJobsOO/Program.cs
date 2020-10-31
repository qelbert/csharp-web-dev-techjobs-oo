using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    class Program
    {
        static void Main()
        {

            Job job1 = new Job("product tester", new Employer("acme"), new Location("desert"), new PositionType("quality control"), new CoreCompetency("persistence"));
            Job job2 = new Job("web developer", new Employer("launchcode"), new Location("st. louis"), new PositionType("front-end developer"), new CoreCompetency("javascript"));
            Job job3 = new Job("ice cream tester", new Employer(""), new Location("home"), new PositionType("ux"), new CoreCompetency("tasting ability"));

            List<Job> jobs = new List<Job> { job1, job2, job3 };

            foreach (Job job in jobs)
            {
                Console.WriteLine(job.ToString());
            }

        }
    }
}
