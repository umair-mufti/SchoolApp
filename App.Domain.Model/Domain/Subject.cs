namespace SchoolApp.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("tbl_Subject")]
    public partial class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        [StringLength(100)]
        public string SubjectName { get; set; }

        [StringLength(100)]
        public string SubjectCode { get; set; }

        [StringLength(100)]
        public string BookNmae { get; set; }

        public int? MinPassingMarks { get; set; }

        public DateTime? DateAdded { get; set; }

        [StringLength(50)]
        public string AddedBy { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(10)]
        public string ModifiedBy { get; set; }

        public int? Active { get; set; }
    }
}
