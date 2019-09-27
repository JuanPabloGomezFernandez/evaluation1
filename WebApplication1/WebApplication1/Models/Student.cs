using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public enum TypeGender
    {
       
        Male,
        Female,
     


    }

    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [required]
        public string Name { get; set; }

        [required]
        public TypeGender Gender { get; set; }

        [required]
        [DataType(DataType.Date)]

        public int Birthday { get; set; }
        [required]
        public virtual ICollection< Grade> Grades{ get; set;}

        }


    }