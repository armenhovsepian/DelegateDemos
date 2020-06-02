namespace PredicateDemo.Model
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UserType Type { get; set; }
    }

    public enum UserType
    {
        Administrator, User, Guest
    }
}
