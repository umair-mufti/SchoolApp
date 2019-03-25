namespace SchoolApp.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("tbl_Class")]
    public partial class tbl_Class
    {
        [Key]
        public int ClassId { get; set; }

        [StringLength(100)]
        public string ClassName { get; set; }

        [StringLength(100)]
        public string ClassCapacity { get; set; }

        public DateTime? ClassStartingOn { get; set; }

        [StringLength(100)]
        public string ClassLocation { get; set; }

        [StringLength(100)]
        public string ClassNumber { get; set; }

        public int? ClassTeacherId { get; set; }

        public DateTime? ClassEndingOn { get; set; }

        public DateTime? DateAdded { get; set; }

        [StringLength(50)]
        public string AddedBy { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(10)]
        public string ModifiedBy { get; set; }

        public int? Active { get; set; }
    }
}
