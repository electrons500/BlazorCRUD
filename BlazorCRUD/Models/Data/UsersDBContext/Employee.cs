using System;
using System.Collections.Generic;

namespace BlazorCRUD.Models.Data.UsersDBContext
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Age { get; set; }
       
    }
}
