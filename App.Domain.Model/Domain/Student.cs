namespace App.Domain.Model
{
    using App.Domain.Model.Contract;
    using App.Domain.Model.Model;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;



    /// <summary>
    /// This will Inherit from Entity<> which contains all the default columns along with the ID, 
    /// passing int as type means the ID type
    /// </summary>
    [Table("tbl_Student")]
    public partial class Student : Entity<int>
    {
        
        //public int StudentId { get; set; }

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

        public int? Active { get; set; }
    }
}
