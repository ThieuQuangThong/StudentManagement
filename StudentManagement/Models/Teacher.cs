namespace StudentManagement.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string Address { get; set; }
        public IList<Class> Classes { get; set; }
    }
}
