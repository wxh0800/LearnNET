namespace LearnEf.Domains
{
    public class Department {
        public int Id {get;set;}
        public int CompanyId {get;set;}
        public Company Company { get; set; }
    }
}