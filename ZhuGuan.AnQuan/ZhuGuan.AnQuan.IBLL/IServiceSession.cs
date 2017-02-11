
 
namespace ZhuGuan.AnQuan.IBLL
{
	public interface IServiceSession
	{
	
		IAccidentInfoService  AccidentInfoService{ get; }
	
		ICaseAnalysisInfoService  CaseAnalysisInfoService{ get; }
	
		IHiddenDangerInfoService  HiddenDangerInfoService{ get; }
	
		IRoleInfoService  RoleInfoService{ get; }
	
		ITeamInfoService  TeamInfoService{ get; }
	
		IUnitInfoService  UnitInfoService{ get; }
	
		IUserInfoService  UserInfoService{ get; }
		//int SaveChanges();
	
	}
}
