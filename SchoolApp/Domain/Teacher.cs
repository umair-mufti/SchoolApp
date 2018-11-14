namespace SchoolApp.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Teacher")]
    public partial class Teacher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teacher()
        {
            Classes = new HashSet<Class>();
        }

        public int TeacherId { get; set; }

        public string Qualification { get; set; }

        public DateTime DateJoin { get; set; }

        public DateTime DateReleave { get; set; }

        public string CurrentPosition { get; set; }

        public string WorkingHours { get; set; }

        public string EmpployeeCode { get; set; }

        public DateTime DateAdd { get; set; }

        public DateTime DateModified { get; set; }

        public string Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class> Classes { get; set; }
    }
}
