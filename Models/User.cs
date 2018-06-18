namespace greatest_least
{

    public class User
    {
        public string Name { get; set; }
        private string Password;
        private string favFood;


        public string GetFood(string password)
        {
            if(password == Password){
                return favFood;
            }
            return "Invalid username / password";
        }

        public User(string name, string password, string food)
        {
            Name = name;
            Password = password;
            favFood = food;
        }

    }


}