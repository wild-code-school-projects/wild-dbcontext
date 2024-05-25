namespace EntityFramework.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SavingAccount> SavingAccounts { get; set; }
    }
}
