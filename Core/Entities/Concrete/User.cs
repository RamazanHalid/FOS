namespace Core.Entities.Concrete
{
    public class User:IEntity   
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string GSM { get; set; }
        public string DOB { get; set; }
        public bool Status { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
}