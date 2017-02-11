
 
namespace ZhuGuan.AnQuan.IDAL
{
	public interface IDbSession
	{
	
		IAccidentInfoDal  AccidentInfoDal{ get; }
	
		ICaseAnalysisInfoDal  CaseAnalysisInfoDal{ get; }
	
		IHiddenDangerInfoDal  HiddenDangerInfoDal{ get; }
	
		IRoleInfoDal  RoleInfoDal{ get; }
	
		ITeamInfoDal  TeamInfoDal{ get; }
	
		IUnitInfoDal  UnitInfoDal{ get; }
	
		IUserInfoDal  UserInfoDal{ get; }
		int SaveChanges();
	
	}
}
