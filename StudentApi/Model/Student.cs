using System.ComponentModel.DataAnnotations;

namespace StudentApi.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

       
        public string FamilyName { get; set; } = null!;


       
        public string Address { get; set; } = null!;

       
        public long ContactNumber { get; set; }

        public int RollName { get; set; }
    }
}
