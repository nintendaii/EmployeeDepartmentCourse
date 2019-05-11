using DataLibrary.DataAccess;
using DataLibrary.ADOModels;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class EmployeeProcessor
    {
        public static void CreateEmployee(string firstName, string lastName, int age, string email,
            int specialityId, int positionid)
        {
            //EmployeeModel data = new EmployeeModel
            //{
            //    FirstName = firstName,
            //    LastName = lastName,
            //    Age = age,
            //    Email = email,
            //    SpecialityId = specialityId,
            //    PositionId = positionid
            //};
            DBDepartmnetEntities model = new DBDepartmnetEntities();
            Employee employee = new Employee();
            employee.FirstName = firstName;
            employee.LastName = lastName;
            employee.Age = age;
            employee.Email = email;
            employee.SpecialityId = specialityId;
            employee.PositionId = positionid;
            model.Employee.Add(employee);
            model.SaveChanges();
            //string sql= @"insert into dbo.Employee (FirstName,LastName,Age,Email,SpecialityId,PositionId) values(
            //@FirstName,@LastName,@Age,@Email,@SpecialityId,@PositionId)";
            //return SQLDataAccess.SaveData(sql, employee);
        }
        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select Id,FirstName,LastName,Age,Email,SpecialityId,PositionId 
                           from dbo.Employee;";
            return SQLDataAccess.LoadData<EmployeeModel>(sql);
        }
        public static void DeleteEmployees(DBDepartmnetEntities models)
        {
            string sql= @"DELETE FROM dbo.Employee WHERE Id = @Id";
        }
    }
}
