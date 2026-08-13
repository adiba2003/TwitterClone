namespace TwitterClone.Domain.Entities
{
    public sealed class TextMessage : Message
    {
        private string _content;

        public TextMessage(
            Guid senderId,
            Guid receiverId,
            string content)
            : base(senderId, receiverId)
        {
            _content = content;
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public override string GetMessageType()
        {
            return "Text";
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, Content: {Content}";
        }
    }
}