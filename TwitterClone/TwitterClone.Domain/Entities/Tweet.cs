namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
        private Guid _id;
        private Guid _authorId;
        private string _content;
        private string _mediaUrl;
        private bool _isEdited;
        private bool _isDeleted;
        private Guid? _replyToTweetId;
        private Guid? _quotedTweetId;
        private DateTime _createdAt;
        private DateTime _updatedAt;

        public Tweet(Guid authorId, string content)
        {
            _id = Guid.NewGuid();
            _authorId = authorId;
            _content = content;
            _isEdited = false;
            _isDeleted = false;
            _createdAt = DateTime.UtcNow;
            _updatedAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid AuthorId
        {
            get { return _authorId; }
        }

        public string Content
        {
            get { return _content; }
            set
            {
                _content = value;
                _isEdited = true;
                _updatedAt = DateTime.UtcNow;
            }
        }

        public string MediaUrl
        {
            get { return _mediaUrl; }
            set { _mediaUrl = value; }
        }

        public bool IsEdited
        {
            get { return _isEdited; }
        }

        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }

        public Guid? ReplyToTweetId
        {
            get { return _replyToTweetId; }
            set { _replyToTweetId = value; }
        }

        public Guid? QuotedTweetId
        {
            get { return _quotedTweetId; }
            set { _quotedTweetId = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public DateTime UpdatedAt
        {
            get { return _updatedAt; }
        }
    }
}