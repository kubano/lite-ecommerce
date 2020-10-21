using System;

namespace Common
{
    public interface IAuditable
    {
        bool? IsDeleted { get; set; }

        byte? DisplayOrder { get; set; }

        string DeletedBy { get; set; }
        DateTime? DeletedOn { get; set; }
        bool IsActive { get; set; }
        string CreatedBy { get; set; }
        DateTime? CreatedOn { get; set; }
        string UpdatedBy { get; set; }
        DateTime? UpdatedOn { get; set; }
        string DeactivatedBy { get; set; }
        DateTime? DeactivatedOn { get; set; }

        string Description { get; set; }
    }
}