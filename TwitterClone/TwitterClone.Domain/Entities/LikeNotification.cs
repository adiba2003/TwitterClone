namespace TwitterClone.Domain.Entities
{
    public sealed class LikeNotification : Notification
    {
        private Guid _likeByUserId;

        public LikeNotification(Guid likeByUserId)
            : base("Like")
        {
            _likeByUserId = likeByUserId;
        }

        public Guid LikeByUserId
        {
            get { return _likeByUserId; }
            set { _likeByUserId = value; }
        }

        public void AddMessage(string message)
        {
            Message = message;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, LikeByUserId: {LikeByUserId}";
        }
    }
}