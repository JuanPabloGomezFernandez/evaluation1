using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public enum TypeGender
    {

        Male,
        Female,
    }

    public class StudentApi
    {
        public class Student
        {
            [Key]
            public string Name { get; set; }
            [required]
            public int TypeGender { get; set; }
            [required]
            public int Birthday { get; set; }



        }


    }
}