namespace SchoolApp.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("tbl_Exam")]
    public partial class Exam
    {
        [Key]
        public int ExamId { get; set; }

        [StringLength(100)]
        public string ExamName { get; set; }

        public DateTime? ExamStartDate { get; set; }

        public DateTime? ExamEndDate { get; set; }

        public int? ClassId { get; set; }

        public int? ExamSubjectId { get; set; }

        public DateTime? DateAdded { get; set; }

        [StringLength(50)]
        public string AddedBy { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(10)]
        public string ModifiedBy { get; set; }

        public int? Active { get; set; }
    }
}
