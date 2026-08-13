namespace TwitterClone.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? ModifiedAt { get; private set; }
        public Guid CreatedBy { get; private set; }
        public Guid? ModifiedBy { get; private set; }

        public BaseEntity(Guid id, Guid createdBy)
        {
            Id = id;
            CreatedBy = createdBy;
            CreatedAt = DateTime.UtcNow;
        }
    }
}