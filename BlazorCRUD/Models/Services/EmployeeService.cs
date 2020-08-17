using BlazorCRUD.Models.Data.UsersDBContext;
using BlazorCRUD.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Models.Services
{
    public class EmployeeService
    {
        private UsersContext _Context;
        public EmployeeService(UsersContext context)
        {
            _Context = context;
        }

        //Get list of employees

        public List<EmployeeViewModel> GetEmployees()
        {
            try
            {
                var employees = _Context.Employee.ToList();
                List<EmployeeViewModel> model = employees.Select(x => new EmployeeViewModel
                {
                    EmployeeId = x.EmployeeId,
                    Firstname = x.Firstname,
                    Lastname = x.Lastname,
                    Age = x.Age
                }).ToList();

                return model;
            }
            catch (Exception)
            {
                List<EmployeeViewModel> emptyModel = new List<EmployeeViewModel>();
                return emptyModel;
              
            }
        }

        // Get employee details

        public EmployeeViewModel GetEmployeeDetails(int id)
        {
            try
            {
                Employee employee = _Context.Employee.Where(x => x.EmployeeId == id).FirstOrDefault();
                EmployeeViewModel model = new EmployeeViewModel
                {
                    EmployeeId = employee.EmployeeId,
                    Firstname = employee.Firstname,
                    Lastname = employee.Lastname,
                    Age = employee.Age
                };

                return model;
            }
            catch (Exception)
            {
                EmployeeViewModel emptyModel = new EmployeeViewModel();
                return emptyModel;
               
            } 

        }


        //Add employee data
          
        public bool AddEmployee()
        {
            try
            {
                EmployeeViewModel model = new EmployeeViewModel();
                Employee employee = new Employee
                {
                    Firstname = model.Firstname,
                    Lastname = model.Lastname,
                    Age = model.Age
                };

                _Context.Add(employee);
                _Context.SaveChanges();

                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }
        

    }
}
