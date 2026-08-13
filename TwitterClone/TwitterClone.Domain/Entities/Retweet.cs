namespace TwitterClone.Domain.Entities
{
    public class Retweet : BaseEntity
    {
        private Guid _userId;
        private Guid _tweetId;
        private string _comment;
        private DateTime _retweetedAt;

        public Retweet() : base(Guid.NewGuid())
        {
            _retweetedAt = DateTime.UtcNow;
        }

        public Retweet(
            Guid userId,
            Guid tweetId,
            string comment)
            : this()
        {
            _userId = userId;
            _tweetId = tweetId;
            _comment = comment;
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

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        public DateTime RetweetedAt
        {
            get { return _retweetedAt; }
            set { _retweetedAt = value; }
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, UserId: {UserId}, TweetId: {TweetId}, Comment: {Comment}, RetweetedAt: {RetweetedAt}";
        }
    }
}