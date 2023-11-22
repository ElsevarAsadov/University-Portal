using System.Data.SqlTypes;

namespace UniPortal.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherFullname { get; set; }
        public string MotherFullname { get; set; }
        public string Living { get; set; }
        public string Graduation { get; set; }
        public string AcademicStatus { get; set; }
        public byte Age { get; set; }
        public DateTime Birth { get; set; }
        public SqlMoney Salary { get; set; }
        public DateTime FirstWorkingData { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}
