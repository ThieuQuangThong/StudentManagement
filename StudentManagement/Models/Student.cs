namespace StudentManagement.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
}
