namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity
    {
        private Guid _userId;
        private string _content;
        private bool _isEdited;
        private bool _isDeleted;

        public Tweet() : base(Guid.NewGuid())
        {

        }

        public Tweet(
            Guid userId,
            string content)
            : this()
        {
            _userId = userId;
            _content = content;
        }

        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public bool IsEdited
        {
            get { return _isEdited; }
            set { _isEdited = value; }
        }

        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }

        public virtual string GetTweetType()
        {
            return "Tweet";
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, UserId: {UserId}, Content: {Content}, IsEdited: {IsEdited}, IsDeleted: {IsDeleted}, TweetType: {GetTweetType()}";
        }
    }
}