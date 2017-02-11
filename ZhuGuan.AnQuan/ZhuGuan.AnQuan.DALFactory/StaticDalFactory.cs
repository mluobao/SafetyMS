
 
using System.Linq;
using System.Reflection;
using System.Text;
using ZhuGuan.AnQuan.IDAL;

namespace ZhuGuan.AnQuan.DALFactory
{
	public class StaticDalFactory
    {
        public static string assemblyName = System.Configuration.ConfigurationManager.AppSettings["DalAssemblyName"];
   
	
		public static IAccidentInfoDal  GetAccidentInfoDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName+".AccidentInfoDal") as IAccidentInfoDal;
		}   
	
		public static ICaseAnalysisInfoDal  GetCaseAnalysisInfoDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName+".CaseAnalysisInfoDal") as ICaseAnalysisInfoDal;
		}   
	
		public static IHiddenDangerInfoDal  GetHiddenDangerInfoDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName+".HiddenDangerInfoDal") as IHiddenDangerInfoDal;
		}   
	
		public static IRoleInfoDal  GetRoleInfoDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName+".RoleInfoDal") as IRoleInfoDal;
		}   
	
		public static ITeamInfoDal  GetTeamInfoDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName+".TeamInfoDal") as ITeamInfoDal;
		}   
	
		public static IUnitInfoDal  GetUnitInfoDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName+".UnitInfoDal") as IUnitInfoDal;
		}   
	
		public static IUserInfoDal  GetUserInfoDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName+".UserInfoDal") as IUserInfoDal;
		}   
	
	}
}