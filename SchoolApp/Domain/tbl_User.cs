namespace SchoolApp.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_User
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(150)]
        public string FirstName { get; set; }

        [StringLength(150)]
        public string MiddleName { get; set; }

        [StringLength(150)]
        public string LastName { get; set; }

        public int? UserRoleId { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public bool? Gender { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(250)]
        public string CurrentAddress { get; set; }

        [StringLength(50)]
        public string CurrentCity { get; set; }

        [StringLength(50)]
        public string CurrentCountry { get; set; }

        [StringLength(50)]
        public string CurrentZipcode { get; set; }

        public bool? IsCurrentPermanentAddressSame { get; set; }

        [StringLength(250)]
        public string PermanenetAddress { get; set; }

        [StringLength(50)]
        public string PermanenetCity { get; set; }

        [StringLength(50)]
        public string PermanenetCountry { get; set; }

        [StringLength(50)]
        public string PermanenetZipcode { get; set; }

        public DateTime? DateAdded { get; set; }

        [StringLength(50)]
        public string AddedBy { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(10)]
        public string ModifiedBy { get; set; }

        public int? Active { get; set; }
    }
}
