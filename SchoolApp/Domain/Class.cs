namespace SchoolApp.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Class")]
    public partial class Class
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Class()
        {
            Teachers = new HashSet<Teacher>();
        }

        public int ClassId { get; set; }

        public string ClassName { get; set; }

        public string ClassCapacity { get; set; }

        public DateTime ClassStartingOn { get; set; }

        public string ClassLocation { get; set; }

        public string ClassNumber { get; set; }

        public DateTime ClassEndingOn { get; set; }

        public string AddedBy { get; set; }

        public string ModifiedBy { get; set; }

        public string Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
