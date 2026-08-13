namespace TwitterClone.Domain.Entities
{
    public class Follow : BaseEntity
    {
        public Guid FollowerId { get; private set; }
        public Guid FollowingId { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime FollowedAt { get; private set; }
        public DateTime? UnfollowedAt { get; private set; }

        public Follow(
            Guid followerId,
            Guid followingId)
            : base(Guid.NewGuid(), followerId)
        {
            FollowerId = followerId;
            FollowingId = followingId;
            IsActive = true;
            FollowedAt = DateTime.UtcNow;
        }
    }
}