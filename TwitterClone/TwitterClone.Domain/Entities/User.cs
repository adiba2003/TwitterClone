namespace TwitterClone.Domain.Entities
{
    public class User
    {
        private Guid _id;
        private string _username;
        private string _email;
        private string _passwordHash;
        private string _firstName;
        private string _lastName;
        private string _bio;
        private string _profileImageUrl;
        private string _location;
        private string _website;
        private bool _isActive;
        private DateTime _createdAt;
        private DateTime _lastLoginAt;

        public User(string username, string email, string passwordHash)
        {
            _id = Guid.NewGuid();
            _username = username;
            _email = email;
            _passwordHash = passwordHash;
            _isActive = true;
            _createdAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string PasswordHash
        {
            get { return _passwordHash; }
            set { _passwordHash = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Bio
        {
            get { return _bio; }
            set { _bio = value; }
        }

        public string ProfileImageUrl
        {
            get { return _profileImageUrl; }
            set { _profileImageUrl = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public string Website
        {
            get { return _website; }
            set { _website = value; }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public DateTime LastLoginAt
        {
            get { return _lastLoginAt; }
            set { _lastLoginAt = value; }
        }
    }
}