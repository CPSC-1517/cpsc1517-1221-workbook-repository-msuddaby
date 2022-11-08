using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WestWindWebApp.Models;

namespace WestWindWebApp.Pages
{
    public class ProjectSelectionModel : PageModel
    {
        public List<Student> Students { get; set; }

        public List<List<Student>> GroupedStudents { get; set; } = new List<List<Student>>();

        public void OnGet()
        {
            var tempStudents = new List<Student>();
            using (var reader = new StreamReader("wwwroot/Data/StudentNames.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Student newStudent = new Student
                    {
                        Id = int.Parse(values[2]),
                        FirstName = values[0],
                        LastName = values[1]
                    };
                    tempStudents.Add(newStudent);

                }
                reader.Close();
            }
            var shuffled = tempStudents.OrderBy(a => Guid.NewGuid()).ToList();

            for (int i = 0; i < shuffled.Count; i++)
            {
                var group = new List<Student>();

                for (int j = 0; j < 3; j++)
                {
                    group.Add(shuffled[j]);
                    shuffled.RemoveAt(j);
                }

                GroupedStudents.Add(group);
                
            }

            Students = shuffled;
        }
    }
}
