namespace TwitterClone.Domain.Entities
{
    public class Like : BaseEntity
    {
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _likedAt;

        public Like() : base(Guid.NewGuid())
        {
            _likedAt = DateTime.UtcNow;
        }

        public Like(
            Guid userId,
            Guid tweetId)
            : this()
        {
            _userId = userId;
            _tweetId = tweetId;
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

        public DateTime LikedAt
        {
            get { return _likedAt; }
            set { _likedAt = value; }
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, UserId: {UserId}, TweetId: {TweetId}, LikedAt: {LikedAt}";
        }
    }
}