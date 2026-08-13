namespace TwitterClone.Domain.Entities
{
    public sealed class TextTweet : Tweet
    {
        public TextTweet(
            Guid userId,
            string content)
            : base(userId, content)
        {

        }

        public override string GetTweetType()
        {
            return "Text";
        }
    }
}