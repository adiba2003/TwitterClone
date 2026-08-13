namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        private Guid _id;
        private Guid _senderId;
        private Guid _receiverId;
        private string _content;
        private bool _isRead;
        private DateTime _sentAt;
        private DateTime? _readAt;
        private DateTime? _editedAt;

        public Message(
            Guid senderId,
            Guid receiverId,
            string content)
        {
            _id = Guid.NewGuid();
            _senderId = senderId;
            _receiverId = receiverId;
            _content = content;
            _isRead = false;
            _sentAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid SenderId
        {
            get { return _senderId; }
        }

        public Guid ReceiverId
        {
            get { return _receiverId; }
        }

        public string Content
        {
            get { return _content; }
            set
            {
                _content = value;
                _editedAt = DateTime.UtcNow;
            }
        }

        public bool IsRead
        {
            get { return _isRead; }
        }

        public DateTime SentAt
        {
            get { return _sentAt; }
        }

        public DateTime? ReadAt
        {
            get { return _readAt; }
        }

        public DateTime? EditedAt
        {
            get { return _editedAt; }
        }

        public void MarkAsRead()
        {
            _isRead = true;
            _readAt = DateTime.UtcNow;
        }
    }
}