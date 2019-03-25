namespace SchoolApp.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("tbl_StudentMarks")]
    public partial class StudentMarks
    {
        [Key]
        public int StudentMarksId { get; set; }

        public int? StudentId { get; set; }

        public int? ClassId { get; set; }

        public int? ExamId { get; set; }

        public int? SubjectId { get; set; }

        public int? MarksObtain { get; set; }

        public int? OutOfMarks { get; set; }

        public DateTime? DateAdded { get; set; }

        [StringLength(50)]
        public string AddedBy { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(10)]
        public string ModifiedBy { get; set; }

        public int? Active { get; set; }
    }
}
