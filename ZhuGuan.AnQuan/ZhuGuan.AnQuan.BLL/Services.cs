
 
using ZhuGuan.AnQuan.IBLL;
using ZhuGuan.AnQuan.Model;

namespace ZhuGuan.AnQuan.BLL
{
	
	public partial class AccidentInfoService : BaseService<AccidentInfo>,IAccidentInfoService
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.AccidentInfoDal;
        }
    }   
	
	public partial class CaseAnalysisInfoService : BaseService<CaseAnalysisInfo>,ICaseAnalysisInfoService
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.CaseAnalysisInfoDal;
        }
    }   
	
	public partial class HiddenDangerInfoService : BaseService<HiddenDangerInfo>,IHiddenDangerInfoService
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.HiddenDangerInfoDal;
        }
    }   
	
	public partial class RoleInfoService : BaseService<RoleInfo>,IRoleInfoService
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.RoleInfoDal;
        }
    }   
	
	public partial class TeamInfoService : BaseService<TeamInfo>,ITeamInfoService
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.TeamInfoDal;
        }
    }   
	
	public partial class UnitInfoService : BaseService<UnitInfo>,IUnitInfoService
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.UnitInfoDal;
        }
    }   
	
	public partial class UserInfoService : BaseService<UserInfo>,IUserInfoService
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.UserInfoDal;
        }
    }   
	
}