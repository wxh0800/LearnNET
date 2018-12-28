using System;
using LearnEf.Data;
using LearnEf.Domains;

namespace LearnEf.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Insert();
        }

        private static void Insert()
        {
            var Company = new Company
            {
                name = "Microsoft",
                StartDate = new DateTime(1975, 4, 4)
            };

            using (var context = new MyContext())
            {
                context.Companies.Add(Company);
                context.SaveChanges();
            }
        }
    }
}
