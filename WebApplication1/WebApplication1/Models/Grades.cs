using System.ComponentModel.DataAnnotations;

namespace WebApplication1
{
    public enum StateType

    {
        Approved,
        Failed,


    }


    public class Grades
    {
        [Required]
        public string Subject { get; set; }
        [Required]
        [Range(0, 100)]
        public int Score { get; set; }
        [Required]
        public StateType State { get; set; }
        [Key]
        public int StudentID { get; set; }


    }
}