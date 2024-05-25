using EntityFramework.Models;

namespace EntityFramework
{
    public static class SavingCalculator
    {
        public static void CalculateSavings(SavingAccount account, int years)
        {
            decimal balance = account.Balance;
            decimal rate = account.InterestRate / 100;

            if (account.InterestType == "monthly")
            {
                for (int i = 0; i < years * 12; i++)
                {
                    balance += balance * rate;
                }
            }
            else if (account.InterestType == "annual")
            {
                for (int i = 0; i < years; i++)
                {
                    balance += balance * rate;
                }
            }

            Console.WriteLine($"Initial balance: {account.Balance:C}, Interest rate: {account.InterestRate}% {account.InterestType}, Balance after {years} years: {balance:C}");
        }
    }
}
