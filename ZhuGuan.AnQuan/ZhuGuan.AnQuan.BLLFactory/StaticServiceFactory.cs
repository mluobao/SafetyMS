
 
using System.Linq;
using System.Reflection;
using System.Text;
using ZhuGuan.AnQuan.IBLL;

namespace ZhuGuan.AnQuan.BLLFactory
{
	public class StaticServiceFactory
    {
        public static string assemblyName = System.Configuration.ConfigurationManager.AppSettings["ServiceAssemblyName"];
   
	
		public static IAccidentInfoService  GetAccidentInfoService()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName+".AccidentInfoService") as IAccidentInfoService;
		}   
	
		public static ICaseAnalysisInfoService  GetCaseAnalysisInfoService()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName+".CaseAnalysisInfoService") as ICaseAnalysisInfoService;
		}   
	
		public static IHiddenDangerInfoService  GetHiddenDangerInfoService()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName+".HiddenDangerInfoService") as IHiddenDangerInfoService;
		}   
	
		public static IRoleInfoService  GetRoleInfoService()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName+".RoleInfoService") as IRoleInfoService;
		}   
	
		public static ITeamInfoService  GetTeamInfoService()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName+".TeamInfoService") as ITeamInfoService;
		}   
	
		public static IUnitInfoService  GetUnitInfoService()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName+".UnitInfoService") as IUnitInfoService;
		}   
	
		public static IUserInfoService  GetUserInfoService()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName+".UserInfoService") as IUserInfoService;
		}   
	
	}
}