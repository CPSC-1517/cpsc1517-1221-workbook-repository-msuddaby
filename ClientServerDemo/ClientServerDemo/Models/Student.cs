namespace WestWindWebApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }


}
