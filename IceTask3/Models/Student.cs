﻿using Microsoft.AspNetCore.Mvc;

namespace IceTask3.Models
{
    
        public class Student
        {
            public int Id { get; set; }

            public string FullName { get; set; }

            public string Email { get; set; }

            public DateTime EnrollmentDate { get; set; }
        }
    
}
