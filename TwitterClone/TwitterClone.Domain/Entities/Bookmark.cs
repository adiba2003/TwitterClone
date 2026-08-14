namespace TwitterClone.Domain.Entities
{
    public class Bookmark : BaseEntity
    {
        private Guid _userId;
        private Guid _tweetId;
        private string _collectionName;
        private DateTime _savedAt;
        private bool _isArchived;

        public Bookmark() : base(Guid.NewGuid())
        {
            _savedAt = DateTime.UtcNow;
            _isArchived = false;
        }

        public Bookmark(
            Guid userId,
            Guid tweetId)
            : this()
        {
            _userId = userId;
            _tweetId = tweetId;
        }

        public Bookmark(
            Guid userId,
            Guid tweetId,
            string collectionName)
            : this(userId, tweetId)
        {
            _collectionName = collectionName;
        }

        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
            set { _tweetId = value; }
        }

        public string CollectionName
        {
            get { return _collectionName; }
            set { _collectionName = value; }
        }

        public DateTime SavedAt
        {
            get { return _savedAt; }
            set { _savedAt = value; }
        }

        public bool IsArchived
        {
            get { return _isArchived; }
            set { _isArchived = value; }
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, UserId: {UserId}, TweetId: {TweetId}, CollectionName: {CollectionName}, SavedAt: {SavedAt}, IsArchived: {IsArchived}";
        }
    }
}