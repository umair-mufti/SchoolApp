namespace SchoolApp.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [StringLength(250)]
        public string Qualification { get; set; }

        public DateTime? DateJoin { get; set; }

        public DateTime? DateReleave { get; set; }

        [StringLength(100)]
        public string CurrentPosition { get; set; }

        [StringLength(100)]
        public string WorkingHours { get; set; }

        [StringLength(100)]
        public string EmployeeCode { get; set; }

        public int? TeacherClassId { get; set; }

        public DateTime? DateAdded { get; set; }

        [StringLength(50)]
        public string AddedBy { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(10)]
        public string ModifiedBy { get; set; }

        public int? Active { get; set; }
    }
}
