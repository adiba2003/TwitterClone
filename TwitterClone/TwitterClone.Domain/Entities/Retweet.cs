namespace TwitterClone.Domain.Entities
{
    public class Retweet : BaseEntity
    {
        public Guid UserId { get; private set; }
        public Guid TweetId { get; private set; }
        public string? Comment { get; private set; }
        public DateTime RetweetedAt { get; private set; }

        public Retweet(
            Guid userId,
            Guid tweetId)
            : base(Guid.NewGuid(), userId)
        {
            UserId = userId;
            TweetId = tweetId;
            RetweetedAt = DateTime.UtcNow;
        }
    }
}