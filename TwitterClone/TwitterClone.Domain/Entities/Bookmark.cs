namespace TwitterClone.Domain.Entities
{
    public class Bookmark : BaseEntity
    {
        public Guid UserId { get; private set; }
        public Guid TweetId { get; private set; }
        public string? CollectionName { get; private set; }
        public DateTime SavedAt { get; private set; }
        public bool IsArchived { get; private set; }

        public Bookmark(
            Guid userId,
            Guid tweetId)
            : base(Guid.NewGuid(), userId)
        {
            UserId = userId;
            TweetId = tweetId;
            SavedAt = DateTime.UtcNow;
            IsArchived = false;
        }
    }
}