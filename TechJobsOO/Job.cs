using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

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
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) :this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
            
        }

        public override string ToString()
        {
            string empty = "Data Not Avaliable";

            string NametoString = this.Name == "" ? empty : this.Name;
            string EmployerNametoString = this.EmployerName.Value == "" ? empty : this.EmployerName.Value;
            string EmployerLocationtoString = this.EmployerLocation.Value == "" ? empty : this.EmployerLocation.Value;
            string JobTypetoString = this.JobType.Value == "" ? empty : this.JobType.Value;
            string JobCoreCompToString = this.JobCoreCompetency.Value == "" ? empty : this.JobCoreCompetency.Value;


            return $"\nID:{this.Id}\nName:{NametoString}\nEmployer:{EmployerNametoString}\nLocation:{EmployerLocationtoString}\nPosition Type:{JobTypetoString}\nCore Competency:{JobCoreCompToString}\n";
            //return ("\n\n");
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id &&
                   EqualityComparer<PositionType>.Default.Equals(JobType, job.JobType);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, JobType);
        }
        // TODO: Generate Equals() and GetHashCode() methods.
    }
}
