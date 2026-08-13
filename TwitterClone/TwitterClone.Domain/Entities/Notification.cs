namespace TwitterClone.Domain.Entities
{
    public class Notification
    {
        private Guid _id;
        private Guid _receiverId;
        private Guid? _senderId;
        private string _type;
        private string _message;
        private Guid? _relatedTweetId;
        private bool _isRead;
        private DateTime _createdAt;
        private DateTime? _readAt;

        public Notification(
            Guid receiverId,
            string type,
            string message)
        {
            _id = Guid.NewGuid();
            _receiverId = receiverId;
            _type = type;
            _message = message;
            _isRead = false;
            _createdAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid ReceiverId
        {
            get { return _receiverId; }
        }

        public Guid? SenderId
        {
            get { return _senderId; }
            set { _senderId = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public Guid? RelatedTweetId
        {
            get { return _relatedTweetId; }
            set { _relatedTweetId = value; }
        }

        public bool IsRead
        {
            get { return _isRead; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public DateTime? ReadAt
        {
            get { return _readAt; }
        }

        public void MarkAsRead()
        {
            _isRead = true;
            _readAt = DateTime.UtcNow;
        }
    }
}