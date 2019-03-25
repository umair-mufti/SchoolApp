namespace SchoolApp.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("tbl_Role")]
    public partial class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleId { get; set; }

        [StringLength(50)]
        public string RoleName { get; set; }

        public DateTime? DateAdded { get; set; }

        [StringLength(50)]
        public string AddedBy { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public int? Active { get; set; }
    }
}
