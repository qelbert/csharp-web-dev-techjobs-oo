using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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

        Job test1;
        Job test2;

        [TestInitialize]

        public void CreateJobObject()
        {
            test1 = new Job("contactName1", new Employer(""), new Location("employerLocation1"), new PositionType("jobType1"), new CoreCompetency("coreCompentency1"));
            test2 = new Job("contactName1", new Employer(""), new Location("employerLocation1"), new PositionType("jobType1"), new CoreCompetency("coreCompentency1"));
        }

        [TestMethod]
        public void JobConstructorSetsAllFields()
        {
            Assert.AreEqual(test1.Name, "contactName1");
        }

        [TestMethod]
        public void JobTestsForEquality()
        {
            Assert.IsFalse(test1.Equals(test2));
        }

        [TestMethod]
        public void JobTestsForRequiredEmptyLines()
        {
            Assert.IsTrue(test1.ToString().Contains(System.Environment.NewLine + "ID"));
            Assert.IsTrue(test1.ToString().Contains("coreCompentency1" + System.Environment.NewLine));
        }

        [TestMethod]
        public void JobTestsLabelFieldAndSingleLines()
        {
            Assert.IsTrue(test1.ToString().Contains("Location:"));
            Assert.IsTrue(test1.ToString().Contains("employerLocation1"));
            Assert.IsTrue(test1.ToString().Contains("Location: employerLocation1" + System.Environment.NewLine + "Position Type:"));
        }

        [TestMethod]
        public void JobTestsEmptyFields()
        {
            Assert.IsTrue(test1.ToString().Contains("Data not available"));
        }

    }
 }
