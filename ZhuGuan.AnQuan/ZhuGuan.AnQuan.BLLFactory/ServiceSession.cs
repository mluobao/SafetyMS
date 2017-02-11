
 
using ZhuGuan.AnQuan.IBLL;

namespace ZhuGuan.AnQuan.BLLFactory
{
	public class ServiceSession:IServiceSession
	{
	
		public IAccidentInfoService  AccidentInfoService
		{
		    get { return StaticServiceFactory.GetAccidentInfoService(); }
		}   
	
		public ICaseAnalysisInfoService  CaseAnalysisInfoService
		{
		    get { return StaticServiceFactory.GetCaseAnalysisInfoService(); }
		}   
	
		public IHiddenDangerInfoService  HiddenDangerInfoService
		{
		    get { return StaticServiceFactory.GetHiddenDangerInfoService(); }
		}   
	
		public IRoleInfoService  RoleInfoService
		{
		    get { return StaticServiceFactory.GetRoleInfoService(); }
		}   
	
		public ITeamInfoService  TeamInfoService
		{
		    get { return StaticServiceFactory.GetTeamInfoService(); }
		}   
	
		public IUnitInfoService  UnitInfoService
		{
		    get { return StaticServiceFactory.GetUnitInfoService(); }
		}   
	
		public IUserInfoService  UserInfoService
		{
		    get { return StaticServiceFactory.GetUserInfoService(); }
		}   
		/*
		public int SaveChanges()
		{
			int count = DbContextFactory.GetCurrentContext().SaveChanges();
			//确保每次对数据库进行增删改都启用一个新的DbContext实例
            CallContext.SetData("DbContext", null);
			return count;
		}*/
	
	}
}
