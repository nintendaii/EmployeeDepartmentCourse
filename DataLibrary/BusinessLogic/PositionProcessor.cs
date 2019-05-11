using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public class PositionProcessor
    {
        public static int CreatePosition(string positionName, double positionSalary)
        {
            PositionModel data = new PositionModel
            {
                PositionName = positionName,
                PositionSalary = positionSalary
            };
            string sql = @"insert into dbo.Position (PositionName,PositionSalary) values(
            @PositionName,@PositionSalary)";
            return SQLDataAccess.SaveData(sql, data);
        }
        public static List<PositionModel> LoadPositions()
        {
            string sql = @"select Id,PositionName,PositionSalary from dbo.Position;";
            return SQLDataAccess.LoadData<PositionModel>(sql);
        }
    }
}
