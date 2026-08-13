namespace TwitterClone.Domain.Entities
{
    public class Follow
    {
        private Guid _id;
        private Guid _followerId;
        private Guid _followingId;
        private bool _isAccepted;
        private DateTime _followedAt;
        private DateTime? _unfollowedAt;

        public Follow(Guid followerId, Guid followingId)
        {
            _id = Guid.NewGuid();
            _followerId = followerId;
            _followingId = followingId;
            _isAccepted = true;
            _followedAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid FollowerId
        {
            get { return _followerId; }
        }

        public Guid FollowingId
        {
            get { return _followingId; }
        }

        public bool IsAccepted
        {
            get { return _isAccepted; }
            set { _isAccepted = value; }
        }

        public DateTime FollowedAt
        {
            get { return _followedAt; }
        }

        public DateTime? UnfollowedAt
        {
            get { return _unfollowedAt; }
            set { _unfollowedAt = value; }
        }
    }
}