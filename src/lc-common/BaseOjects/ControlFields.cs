using System;

namespace Common
{
    public abstract class ControlFields : IAuditable
    {
        public byte? DisplayOrder { get; set; }
        public bool? IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public bool IsActive { get; set; } = true;
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string DeactivatedBy { get; set; }
        public DateTime? DeactivatedOn { get; set; }
        public virtual string Description { get; set; }
    }
}