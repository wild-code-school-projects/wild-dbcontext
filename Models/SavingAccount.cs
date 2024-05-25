
namespace EntityFramework.Models
{
    public class SavingAccount
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }

        public string InterestType { get; set; } // "monthly" or "annual"
    }
}
