namespace TwitterClone.Domain.Entities
{
    public sealed class CommentNotification : Notification
    {
        private Guid _commentByUserId;

        public CommentNotification(Guid commentByUserId)
            : base("Comment")
        {
            _commentByUserId = commentByUserId;
        }

        public Guid CommentByUserId
        {
            get { return _commentByUserId; }
            set { _commentByUserId = value; }
        }

        public void AddMessage(string message)
        {
            Message = message;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, CommentByUserId: {CommentByUserId}";
        }
    }
}