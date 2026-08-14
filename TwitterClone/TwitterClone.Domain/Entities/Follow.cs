namespace TwitterClone.Domain.Entities
{
    public class Follow : BaseEntity
    {
        private Guid _followerId;
        private Guid _followingId;
        private bool _isActive;
        private DateTime _followedAt;

        public Follow() : base(Guid.NewGuid())
        {
            _isActive = true;
            _followedAt = DateTime.UtcNow;
        }

        public Follow(
            Guid followerId,
            Guid followingId)
            : this()
        {
            _followerId = followerId;
            _followingId = followingId;
        }

        public Guid FollowerId
        {
            get { return _followerId; }
            set { _followerId = value; }
        }

        public Guid FollowingId
        {
            get { return _followingId; }
            set { _followingId = value; }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public DateTime FollowedAt
        {
            get { return _followedAt; }
            set { _followedAt = value; }
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, FollowerId: {FollowerId}, FollowingId: {FollowingId}, IsActive: {IsActive}, FollowedAt: {FollowedAt}";
        }
    }
}