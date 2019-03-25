namespace SchoolApp.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("tbl_TimeTable")]
    public partial class TimeTable
    {
        [Key]
        public int TimeTableId { get; set; }

        [StringLength(100)]
        public string TimeTableName { get; set; }

        public DateTime? TimeTableStartDate { get; set; }

        public DateTime? TimeTableEndDate { get; set; }

        public int? ClassId { get; set; }

        public int? TimeTableSubjectId { get; set; }

        public DateTime? DateAdded { get; set; }

        [StringLength(50)]
        public string AddedBy { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(10)]
        public string ModifiedBy { get; set; }

        public int? Active { get; set; }
    }
}
