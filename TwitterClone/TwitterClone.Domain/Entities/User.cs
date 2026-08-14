namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity
    {
        private string _firstName;
        private string _lastName;
        private string _username;
        private string _email;
        private string _passwordHash;
        private string _bio;
        private string _profileImageUrl;
        private string _location;
        private string _website;
        private bool _isActive;

        public User() : base(Guid.NewGuid())
        {

        }

        public User(
            string firstName,
            string lastName,
            string email)
            : this()
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
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

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, FirstName: {FirstName}, LastName: {LastName}, Username: {Username}, Email: {Email}, Bio: {Bio}, Location: {Location}, Website: {Website}, IsActive: {IsActive}";
        }
    }
}