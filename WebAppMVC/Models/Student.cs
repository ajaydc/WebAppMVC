namespace WebAppMVC.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Branch { get; set; }
        public string? Section { get; set; }
    }

    public class StudentBusinessLayer
    {
        public IEnumerable<Student> GetAll()
        {
            //logic to return all employees
            return new List<Student>();
        }
        public Student GetById(int StudentID)
        {
            //logic to return an employee by employeeId
            Student student = new Student()
            {
                StudentID = StudentID,
                Name = "James",
                Gender = "Male",
                Branch = "CSE",
                Section = "A2",
            };
            return student;
        }
        public void Insert(Student student)
        {
            //logic to insert a student
        }
        public void Update(Student student)
        {
            //logic to Update a student
        }
        public void Delete(int StudentID)
        {
            //logic to Delete a student
        }
    }
}
