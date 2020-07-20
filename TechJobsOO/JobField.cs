using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; set; }
        public static int nextId = 1;
        public string Value { get; set; }

        public virtual int GetJobField()
        {
            Id = nextId;
            return nextId++;
        }

        public JobField(string value) 
        {
            Value = value;
        }

       

        public override string ToString()
        {
            return Value;
        }
        public override bool Equals(object obj)
        {
            return obj is JobField jobField &&
                   Id == jobField.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
