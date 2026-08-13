namespace TwitterClone.Domain.Entities
{
    public class Message : BaseEntity
    {
        public Guid SenderId { get; private set; }
        public Guid ReceiverId { get; private set; }
        public string Content { get; private set; }
        public bool IsRead { get; private set; }
        public DateTime SentAt { get; private set; }
        public DateTime? ReadAt { get; private set; }
        public DateTime? EditedAt { get; private set; }

        public Message(
            Guid senderId,
            Guid receiverId,
            string content)
            : base(Guid.NewGuid(), senderId)
        {
            SenderId = senderId;
            ReceiverId = receiverId;
            Content = content;
            IsRead = false;
            SentAt = DateTime.UtcNow;
        }
    }
}