using System.Data.SqlTypes;

namespace UniPortal.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        //TODO Teacher can have multiple speciality
        public string Speciality { get; set; }
        public string FatherFullname { get; set; }
        public string MotherFullname { get; set; }
        public string Living { get; set; }
        public byte Age { get; set; }
        public int GroupId { get; set; }
        public SqlMoney Scholarship { get; set; }
        public DateTime Birth { get; set; }
        public DateTime Entrance { get; set; }
               
        public Group Group { get; set; }
        //TODO Student Grade
    }
}
