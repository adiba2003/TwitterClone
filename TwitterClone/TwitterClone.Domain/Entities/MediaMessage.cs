namespace TwitterClone.Domain.Entities
{
    public sealed class MediaMessage : Message
    {
        private string _mediaUrl;
        private string _caption;

        public MediaMessage(
            Guid senderId,
            Guid receiverId,
            string mediaUrl)
            : base(senderId, receiverId)
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

        public override string GetMessageType()
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