namespace TwitterClone.Domain.Entities
{
    public class Message : BaseEntity
    {
        private Guid _senderId;
        private Guid _receiverId;
        private DateTime _sentAt;
        private bool _isRead;
        private DateTime? _readAt;

        public Message() : base(Guid.NewGuid())
        {
            _sentAt = DateTime.UtcNow;
            _isRead = false;
        }

        public Message(
            Guid senderId,
            Guid receiverId)
            : this()
        {
            _senderId = senderId;
            _receiverId = receiverId;
        }

        public Guid SenderId
        {
            get { return _senderId; }
            set { _senderId = value; }
        }

        public Guid ReceiverId
        {
            get { return _receiverId; }
            set { _receiverId = value; }
        }

        public DateTime SentAt
        {
            get { return _sentAt; }
            set { _sentAt = value; }
        }

        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }

        public DateTime? ReadAt
        {
            get { return _readAt; }
            set { _readAt = value; }
        }

        public virtual string GetMessageType()
        {
            return "Message";
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, SenderId: {SenderId}, ReceiverId: {ReceiverId}, SentAt: {SentAt}, IsRead: {IsRead}, ReadAt: {ReadAt}, MessageType: {GetMessageType()}";
        }
    }
}