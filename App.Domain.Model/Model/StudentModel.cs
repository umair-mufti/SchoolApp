using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Model
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateJoin { get; set; }
        public DateTime? DateReleave { get; set; }
        public int? StudentClassId { get; set; }
        public string RollNumber { get; set; }
        public int? ParentId { get; set; }
        public DateTime? DateAdded { get; set; }
        public string AddedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public int? Active { get; set; }
    }
}
