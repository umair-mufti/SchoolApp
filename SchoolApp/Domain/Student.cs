namespace SchoolApp.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbl_Student")]
    public partial class Student
    {
        [Key]
        public int StudentId { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        public DateTime? DateJoin { get; set; }

        public DateTime? DateReleave { get; set; }

        public int? StudentClassId { get; set; }

        [StringLength(10)]
        public string RollNumber { get; set; }

        public int? ParentId { get; set; }

        public DateTime? DateAdded { get; set; }

        [StringLength(50)]
        public string AddedBy { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(10)]
        public string ModifiedBy { get; set; }

        public int? Active { get; set; }
    }
}
