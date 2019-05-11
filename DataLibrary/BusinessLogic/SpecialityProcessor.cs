using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public class SpecialityProcessor
    {
        public static int CreateSpeciality(string specialityName, string specialityEducation)
        {
            SpecialityModel data = new SpecialityModel
            {
                SpecialityName=specialityName,
                SpecialityEducation= specialityEducation
            };
            string sql = @"insert into dbo.Speciality (SpecialityName,SpecialityEducation) values(
            @SpecialityName,@SpecialityEducation)";
            return SQLDataAccess.SaveData(sql, data);
        }
        public static List<SpecialityModel> LoadSpecialities()
        {
            string sql = @"select Id,SpecialityName,SpecialityEducation from dbo.Speciality;";
            return SQLDataAccess.LoadData<SpecialityModel>(sql);
        }
    }
}
