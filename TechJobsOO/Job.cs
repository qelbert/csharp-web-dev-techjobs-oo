using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency)
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
            Id = nextId;
            nextId++;

        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Generate Equals() and GetHashCode() methods.

        public override string ToString()
        {
            string stringId = Id.ToString();
            string combinedJobList = "";

            Dictionary<string, string> fields = new Dictionary<string, string>
            {
                {"ID", stringId},
                {"Name", Name},
                {"Employer", EmployerName.ToString()},
                {"Location", EmployerLocation.ToString()},
                {"Position Type", JobType.ToString()},
                {"Core Competency", JobCoreCompetency.ToString()},
            };

            Console.WriteLine(System.Environment.NewLine);

            foreach (KeyValuePair<string, string> field in fields)
            {
                
                string isFieldNull;

                if (field.Value == "")
                {
                    isFieldNull = "Data not available";
                }
                else
                {
                    isFieldNull = field.Value;
                }

                //Console.WriteLine(field.Key + ": " + isFieldNull);
                combinedJobList += field.Key + ": " + isFieldNull + System.Environment.NewLine;
            }

            return combinedJobList;
        }
    }
}
