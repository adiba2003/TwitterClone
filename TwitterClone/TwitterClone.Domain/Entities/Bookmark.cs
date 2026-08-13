namespace TwitterClone.Domain.Entities
{
    public class Bookmark
    {
        private Guid _id;
        private Guid _userId;
        private Guid _tweetId;
        private string _collectionName;
        private DateTime _savedAt;
        private bool _isArchived;

        public Bookmark(Guid userId, Guid tweetId)
        {
            _id = Guid.NewGuid();
            _userId = userId;
            _tweetId = tweetId;
            _savedAt = DateTime.UtcNow;
            _isArchived = false;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid UserId
        {
            get { return _userId; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
        }

        public string CollectionName
        {
            get { return _collectionName; }
            set { _collectionName = value; }
        }

        public DateTime SavedAt
        {
            get { return _savedAt; }
        }

        public bool IsArchived
        {
            get { return _isArchived; }
            set { _isArchived = value; }
        }
    }
}