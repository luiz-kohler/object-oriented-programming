
namespace OOP
{
    // Encapsulation and Abstraction
    public abstract class AccountInfo
    {
        protected string Email { get; set; } // Encapsulated and protected

        public abstract void SetEmail(string email); // Abstraction: Hide implementation details
    }

    // Inheritance
    public class Account : AccountInfo
    {
        private string Password { get; set; } // Encapsulated and private
        private int Cash { get; set; } // Encapsulated and private

        public int GetCash() => Cash; // Public method to access private data
        public void AddIncome(int income) => Cash += income; // Public method to modify private data
        public void AddOutcome(int outcome) => Cash -= outcome; // Public method to modify private data

        public override void SetEmail(string email) // Implementation of abstract method
        {
            Email = email;
        }

        public string GetEmail() // Public method to access protected data
        {
            return Email;
        }
    }

    // Polymorphism
    public interface IUser
    {
        string Name { get; set; }
        int GetAccountCash();
        string GetAccountEmail();
    }

    public class User : IUser
    {
        public string Name { get; set; }
        public Account Account { get; set; }

        public User(string name, Account account)
        {
            Name = name;
            Account = account;
        }

        public int GetAccountCash()
        {
            return Account.GetCash(); // Accessing private data through public method
        }

        public string GetAccountEmail()
        {
            return Account.GetEmail(); // Accessing protected data through public method
        }
    }
}

