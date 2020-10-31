using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;


namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {

        [TestMethod]
        public void TestSettingJobId()
        {
            Job test1 = new Job();
            Job test2 = new Job();
            Assert.IsFalse(test1.Id == test2.Id);
        }

        [TestMethod]
        public void JobConstructorSetsAllFields()
        {
            Job test1 = new Job("contactName1", new Employer("employerName1"), new Location("employerLocation1"), new PositionType ("jobType1"), new CoreCompetency("coreCompentency1"));

            Assert.AreEqual(test1.Name, "contactName1");
        }

        [TestMethod]
        public void JobTestsForEquality()
        {
            Job test1 = new Job("contactName1", new Employer("employerName1"), new Location("employerLocation1"), new PositionType("jobType1"), new CoreCompetency("coreCompentency1"));
            Job test2 = new Job("contactName1", new Employer("employerName1"), new Location("employerLocation1"), new PositionType("jobType1"), new CoreCompetency("coreCompentency1"));

            Assert.IsFalse(test1.Equals(test2));
        }

        [TestMethod]
        public void JobTestsToStringMethod()
        {
            Job test1 = new Job("contactName1", new Employer("employerName1"), new Location("employerLocation1"), new PositionType("jobType1"), new CoreCompetency("coreCompentency1"));

            //Assert.AreEqual(System.Environment.NewLine + "contactName1" + System.Environment.NewLine, test1.ToString());

            Assert.AreEqual(System.Environment.NewLine + "ID: " + test1.Id + System.Environment.NewLine + "Name: " + "contactName1" + System.Environment.NewLine + "Employer: " + "employerName1" + System.Environment.NewLine + "Location: " + "employerLocation1" + System.Environment.NewLine + "Position Type: " + "jobType1" + System.Environment.NewLine + "Core Competency: " + "coreCompentency1", test1.ToString());
        }


    }
 }
