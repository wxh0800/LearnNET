using System;
using System.Collections.Generic;

namespace LearnEf.Domains {
    public class Company
    {
        public Company()
        {
            Departments = new List<Department>();
        }

        public int Id {get;set;}
        public string name {get;set;}
        public DateTime StartDate {get; set;}
        public List<Department> Departments {get;set;}
    }
}
