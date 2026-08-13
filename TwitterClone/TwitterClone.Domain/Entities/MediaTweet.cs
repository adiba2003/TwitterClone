namespace TwitterClone.Domain.Entities
{
    public sealed class MediaTweet : Tweet
    {
        private string _mediaUrl;
        private string _caption;

        public MediaTweet(
            Guid userId,
            string content,
            string mediaUrl)
            : base(userId, content)
        {
            _mediaUrl = mediaUrl;
        }

        public string MediaUrl
        {
            get { return _mediaUrl; }
            set { _mediaUrl = value; }
        }

        public string Caption
        {
            get { return _caption; }
            set { _caption = value; }
        }

        public override string GetTweetType()
        {
            return "Media";
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, MediaUrl: {MediaUrl}, Caption: {Caption}";
        }
    }
}