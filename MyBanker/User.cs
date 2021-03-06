namespace MyBanker
{
    public class User
    {
        private string name;
        private int age;

        //constructor
        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        
        //incapsulation
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}