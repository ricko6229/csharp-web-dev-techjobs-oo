using TechJobsOO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JobTests.cs
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJob = new Job();
            Job testJob2 = new Job();

            Assert.IsTrue(testJob.Id != (testJob2.Id));

        }

        [TestMethod]

        public void TestJobConstructorSetsAllFields()
        {
            Job testJob3 = new Job("Product tester",new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"),new CoreCompetency("Persistence"));


            Assert.AreEqual("Product tester", testJob3.Name);
            Assert.AreEqual("ACME", testJob3.EmployerName.Value);
            Assert.AreEqual("Desert", testJob3.EmployerLocation.Value);
            Assert.AreEqual("Quality control", testJob3.JobType.Value);
            Assert.AreEqual("Persistence", testJob3.JobCoreCompetency.Value);
        }

        [TestMethod]

        /*public void TestJobsForEquality()
        {
            Job testJob3 = new Job(name: "Product tester", employerName: "ACME", employerLocation: "Desert", jobType: "Quality control", jobCoreCompetency: "Persistence");
            Job testJob4 = new Job(name: "Product tester", employerName: "ACME", employerLocation: "Desert", jobType: "Quality control", jobCoreCompetency: "Persistence");

            Assert.IsTrue(testJob3.Id.Equals(testJob4.Id));
        }
        */
        //public override string () 

        public void TestJobForNewLine()
        {
            Job testJob3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string StringValue = testJob3.ToString();


            Assert.IsTrue(StringValue.StartsWith("\n"));
            Assert.IsTrue(StringValue.EndsWith("\n"));
        }
        [TestMethod]
        public void TestJobForLabels()
        {
            Job testJob3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string StringValue = testJob3.ToString();

            string ExpectedOutput = $"\nID:{testJob3.Id}\nName:{testJob3.Name}\nEmployer:{testJob3.EmployerName}\nLocation:{testJob3.EmployerLocation}\nPosition Type:{testJob3.JobType}\nCore Competency:{testJob3.JobCoreCompetency}\n";


            Assert.AreEqual(ExpectedOutput, StringValue);
        }
        [TestMethod]
        public void TestJobForEmptyness()
        {
            Job testJob3 = new Job("Product tester", new Employer("ACME"), new Location(""), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string stringValue = testJob3.ToString();

            string ExpectedOutput = $"\nID:{testJob3.Id}\nName:{testJob3.Name}\nEmployer:{testJob3.EmployerName}\nLocation:Data Not Avaliable\nPosition Type:{testJob3.JobType}\nCore Competency:{testJob3.JobCoreCompetency}\n";

            Assert.AreEqual(ExpectedOutput, stringValue);
        }
    }
}
