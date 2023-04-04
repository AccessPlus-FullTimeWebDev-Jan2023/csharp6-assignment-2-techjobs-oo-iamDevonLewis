
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
        //initalize your testing objects here
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        [TestMethod]
        public void TestSettingJobId()
        {
            //Assert.AreEqual(1, job1.Id);
            //Assert.AreEqual(2,job2.Id);
            Assert.IsFalse(job1.Id.Equals(job2.Id));
            
            
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual("ACME", job3.EmployerName.Value);
            Assert.AreEqual("Desert", job3.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job3.JobType.Value);
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.Value);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job1.Id.Equals(job2.Id));
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job3.ToString().StartsWith(Environment.NewLine));
            Assert.IsTrue(job3.ToString().EndsWith(Environment.NewLine));
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Assert.AreEqual(Environment.NewLine + $" ID: {job4.Id}" + Environment.NewLine + " Name: Product tester" + Environment.NewLine + " Employer: ACME" + Environment.NewLine + " Location: Desert" + Environment.NewLine + " Position Type: Quality control" + Environment.NewLine + " Core Competency: Persistence" + Environment.NewLine,job4.ToString());
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Job job5 = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            Assert.AreEqual(Environment.NewLine + $" ID: {job5.Id}" + Environment.NewLine + " Name: Data not available" + Environment.NewLine + " Employer: Data not available" + Environment.NewLine + " Location: Data not available" + Environment.NewLine + " Position Type: Data not available" + Environment.NewLine + " Core Competency: Data not available" + Environment.NewLine, job5.ToString());
        }
    }
}

