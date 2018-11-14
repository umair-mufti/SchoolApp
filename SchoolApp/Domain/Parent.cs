namespace SchoolApp.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbl_Parent")]
    public partial class Parent
    {
        [Key]
        public int ParentId { get; set; }

        public DateTime? DateJoin { get; set; }

        public DateTime? DateReleave { get; set; }

        public int? ParentStudentId { get; set; }

        [StringLength(50)]
        public string Qualification { get; set; }

        [StringLength(50)]
        public string Profession { get; set; }

        [StringLength(50)]
        public string SecondaryPhone { get; set; }

        [StringLength(50)]
        public string SecondaryEmail { get; set; }

        public DateTime? DateAdded { get; set; }

        [StringLength(50)]
        public string AddedBy { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(10)]
        public string ModifiedBy { get; set; }

        public int? Active { get; set; }
    }
}
