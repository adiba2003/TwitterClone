namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity
    {
        public Guid AuthorId { get; private set; }
        public string Content { get; private set; }
        public string? MediaUrl { get; private set; }
        public bool IsEdited { get; private set; }
        public bool IsDeleted { get; private set; }
        public Guid? ReplyToTweetId { get; private set; }
        public Guid? QuotedTweetId { get; private set; }

        public Tweet(
            Guid authorId,
            string content)
            : base(Guid.NewGuid(), authorId)
        {
            AuthorId = authorId;
            Content = content;
            IsEdited = false;
            IsDeleted = false;
        }
    }
}