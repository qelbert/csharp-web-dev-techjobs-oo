using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {

        //[TestInitialize]
        //public void CreateObjects()
        //{
        //}

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

            Assert.IsTrue(Equals(test1,test2));
        }


    }
 }
