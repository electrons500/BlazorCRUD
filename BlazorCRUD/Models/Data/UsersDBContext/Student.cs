using System;
using System.Collections.Generic;

namespace BlazorCRUD.Models.Data.UsersDBContext
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentCourse { get; set; }
    }
}
