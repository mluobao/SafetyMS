using System.Runtime.Remoting.Messaging;
using ZhuGuan.AnQuan.DAL;
using ZhuGuan.AnQuan.IDAL;

namespace ZhuGuan.AnQuan.DALFactory
{
	public class DbSession:IDbSession
	{
	
		public IAccidentInfoDal  AccidentInfoDal
		{
		    get { return StaticDalFactory.GetAccidentInfoDal(); }
		}   
	
		public ICaseAnalysisInfoDal  CaseAnalysisInfoDal
		{
		    get { return StaticDalFactory.GetCaseAnalysisInfoDal(); }
		}   
	
		public IHiddenDangerInfoDal  HiddenDangerInfoDal
		{
		    get { return StaticDalFactory.GetHiddenDangerInfoDal(); }
		}   
	
		public IRoleInfoDal  RoleInfoDal
		{
		    get { return StaticDalFactory.GetRoleInfoDal(); }
		}   
	
		public ITeamInfoDal  TeamInfoDal
		{
		    get { return StaticDalFactory.GetTeamInfoDal(); }
		}   
	
		public IUnitInfoDal  UnitInfoDal
		{
		    get { return StaticDalFactory.GetUnitInfoDal(); }
		}   
	
		public IUserInfoDal  UserInfoDal
		{
		    get { return StaticDalFactory.GetUserInfoDal(); }
		}   
		public int SaveChanges()
		{
			int count = DbContextFactory.GetCurrentContext().SaveChanges();
			//确保每次对数据库进行增删改都启用一个新的DbContext实例
            CallContext.SetData("DbContext", null);
			return count;
		}
	
	}
}
