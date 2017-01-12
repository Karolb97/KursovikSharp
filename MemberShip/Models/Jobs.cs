namespace MemberShip.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jobs
    {
        public int idJobs { get; set; }
        public int idEmployer { get; set; }
        public string NameJobs { get; set; }
        public int Salary { get; set; }
        public string Requirements { get; set; }
        public string Duties { get; set; }
        public string Conditions { get; set; }
        public string TypeEmployment { get; set; }
        public string Communication { get; set; }
        public string Description { get; set; }
        public System.DateTime TimeCreation { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual Employer Employer { get; set; }
    }
}
