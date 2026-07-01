namespace Todo.Infrastructure.Persistence.Entities
{
    public abstract class BaseAuditableEntity: BaseEntity
    {
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime? UpdateAt { get; set; }
        public string CreatedBy { get; set; }
        public string? UpdateBy { get; set; }
    }
}
