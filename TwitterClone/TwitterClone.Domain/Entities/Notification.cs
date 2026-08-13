namespace TwitterClone.Domain.Entities
{
    public class Notification : BaseEntity
    {
        public Guid ReceiverId { get; private set; }
        public Guid? SenderId { get; private set; }
        public string Type { get; private set; }
        public string Message { get; private set; }
        public Guid? RelatedTweetId { get; private set; }
        public bool IsRead { get; private set; }
        public DateTime? ReadAt { get; private set; }

        public Notification(
            Guid receiverId,
            string type,
            string message)
            : base(Guid.NewGuid(), receiverId)
        {
            ReceiverId = receiverId;
            Type = type;
            Message = message;
            IsRead = false;
        }
    }
}