using EntityFramework.Models;

namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationDBContext())
            {

                // If the database already exist then we delete it 
                context.Database.EnsureDeleted();

                // Create the database 
                context.Database.EnsureCreated();

                var person = new Person
                {
                    Name = "Mr Richard",
                    SavingAccounts = new List<SavingAccount>
                    {
                        new SavingAccount { Balance = 2000000, InterestRate = 5, InterestType = "monthly" },
                        new SavingAccount { Balance = 250000, InterestRate = 15, InterestType = "annual" },
                        new SavingAccount { Balance = 10000000, InterestRate = 2, InterestType = "annual" }
                    }
                };


                context.Person.Add(person);

                // Save the new changes 
                context.SaveChanges();

                foreach (var account in person.SavingAccounts)
                    SavingCalculator.CalculateSavings(account, 3);
            }
        }
    }
}
