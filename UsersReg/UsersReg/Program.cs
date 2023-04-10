namespace UsersReg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name: ");
            string userName=Console.ReadLine();
            Console.WriteLine("Enter your Password: ");
            string password=Console.ReadLine(); 
            Console.WriteLine("Enter your Email: ");
            string email=Console.ReadLine();
            User user1=new User(userName,password,email);
            Console.WriteLine($"You create an account at {user1.CreatedDate}, your ID is {user1.ID}");
            user1.LogIn(userName, password);
            
            //Console.WriteLine(user1.CheckPassword(password));
            Console.WriteLine("Enter your new password: ");
            string newPassword=Console.ReadLine();
            user1.ChangePassword(password, newPassword);
            user1.GetLastLogTime();
        }
    }
}