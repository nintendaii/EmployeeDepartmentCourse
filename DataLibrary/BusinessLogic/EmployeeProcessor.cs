using DataLibrary.DataAccess;
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
        public static int CreateEmployee(string firstName, string lastName, int age, string email,
            int specialityId, int positionid)
        {
            EmployeeModel data = new EmployeeModel
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Email = email,
                SpecialityId = specialityId,
                PositionId = positionid
            }; 
            string sql= @"insert into dbo.Employee (FirstName,LastName,Age,Email,SpecialityId,PositionId) values(
            @FirstName,@LastName,@Age,@Email,@SpecialityId,@PositionId)";
            return SQLDataAccess.SaveData(sql, data);
        }
        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select Id,FirstName,LastName,Age,Email,SpecialityId,PositionId 
                           from dbo.Employee;";
            return SQLDataAccess.LoadData<EmployeeModel>(sql);
        }
        //public static List<EmployeeModel> DeleteEmployees()
        //{
        //    string sql = @"delete from dbo.Employee where Id=@Id";
        //    return SQLDataAccess.DeleteData<EmployeeModel>(sql);
        //}
    }
}
