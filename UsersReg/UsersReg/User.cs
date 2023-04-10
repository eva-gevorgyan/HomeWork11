using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersReg
{
    internal class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserEmail { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastLogIn { get;set; }
        private int hashCode { get; set; }
        public User(string UserName,string Password,string UserEmail)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.UserEmail = UserEmail;
            hashCode = Password.GetHashCode();
            CreatedDate = DateTime.Now;
            ID = new Random().Next();
        }
        public void LogIn(string username, string password)
        {
            if (CheckPassword(password))
            {
                LastLogIn = DateTime.Now;
                Console.WriteLine("You have loged in");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        public void GetLastLogTime()
        {
            Console.WriteLine("Last logIn was at " + LastLogIn);
        }
        public bool CheckPassword(string password)
        {
            return string.Equals(password, Password);
        }
        public void ChangePassword(string currentPassword, string newPassword)
        {
            if (CheckPassword(currentPassword))
            {
                Password = newPassword;
                hashCode = newPassword.GetHashCode();
                Console.WriteLine($"Your new password is: {newPassword} and HashCode is: {hashCode}");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        
    }
}
