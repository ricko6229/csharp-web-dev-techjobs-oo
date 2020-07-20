using System;
namespace TechJobsOO
{
    public class Employer : JobField
    {

        public Employer(string value) : base(value) 
        {
  
        }
        public static implicit operator Employer(string v)
        {
            throw new NotImplementedException();
        }
    }
}
