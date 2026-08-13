namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; private set; }
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Bio { get; private set; }
        public string ProfileImageUrl { get; private set; }
        public string Location { get; private set; }
        public string Website { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime? LastLoginAt { get; private set; }

        public User(
            Guid createdBy,
            string username,
            string email,
            string passwordHash,
            string firstName,
            string lastName)
            : base(Guid.NewGuid(), createdBy)
        {
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            FirstName = firstName;
            LastName = lastName;
            IsActive = true;
        }
    }
}