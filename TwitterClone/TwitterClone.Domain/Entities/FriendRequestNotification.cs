namespace TwitterClone.Domain.Entities
{
    public sealed class FriendRequestNotification : Notification
    {
        private Guid _requestedByUserId;

        public FriendRequestNotification(Guid requestedByUserId)
            : base("FriendRequest")
        {
            _requestedByUserId = requestedByUserId;
        }

        public Guid RequestedByUserId
        {
            get { return _requestedByUserId; }
            set { _requestedByUserId = value; }
        }

        public void AddMessage(string message)
        {
            Message = message;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, RequestedByUserId: {RequestedByUserId}";
        }
    }
}