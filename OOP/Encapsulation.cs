
namespace OOP
{
    // - Public: Members declared as public can be accessed from anywhere and any class.
    // - Private: Members declared as private are only accessible inside the class.
    // - Protected: Members declared as protected are accessible within the same class and its derived classes.
    // - Internal: Members declared as internal are accessible within the same assembly.


    public class AccountInfo
    {
        protected string Email { get; set; }
    }


    public class Account : AccountInfo
    {
        private string Password { get; set; }
        private int Cash { get; set; }

        public int GetCash() => Cash;
        public void AddIncome(int income) => Cash = Cash + income;
        public void AddOutcome(int outcome) => Cash = Cash - outcome;

        public string GetEmail()
        {
            // We just have access to the email, because this class "Account" is a subclass from "AccountInfo".
            return Email;
        }
    }

    public class User
    {
        public string Name { get; set; }
        public Account Account { get; set; }

        public int GetAccountCash()
        {
            // Will not work, because Cash is a private prop and it's only accessible from account class.
            //return Account.Cash;

            // The only way we can access the value of Cash, by a public method.
            return Account.GetCash();
        }

        public string GetAccountEmail()
        {
            // Will not work, because Cash is a private prop and it's only accessible from "AccountInfo" and its subclasses like "account" class.
            //return Account.Email;

            // The only way we can access the value of Email, by a public method from "Account".
            return Account.GetEmail();
        }
    }
}
