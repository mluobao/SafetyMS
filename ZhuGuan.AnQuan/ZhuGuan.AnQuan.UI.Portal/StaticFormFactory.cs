using ZhuGuan.AnQuan.UI.Portal.AccidentInfoUI;
using ZhuGuan.AnQuan.UI.Portal.HiddenDangerInfoUI;
using ZhuGuan.AnQuan.UI.Portal.TeamInfoUI;
using ZhuGuan.AnQuan.UI.Portal.UnitInfoUI;
using ZhuGuan.AnQuan.UI.Portal.UserInfoUI;

namespace ZhuGuan.AnQuan.UI.Portal
{
    public class StaticFormFactory
    {
        private static HiddenDangerInfoListFrm HiddenDangerInfo { get; set; }

        private static AccidentInfoListFrm AccidentInfo { get; set; }

        private static TeamInfoListFrm TeamInfo { get; set; }

        private static UnitInfoListFrm UnitInfo { get; set; }

        private static UserInfoListFrm UserInfo { get; set; }
        
        public static HiddenDangerInfoListFrm GetHiddenDangerInfoListFrm()
        {
            if (HiddenDangerInfo == null || HiddenDangerInfo.IsDisposed)
            {
                HiddenDangerInfo=new HiddenDangerInfoListFrm();
            }
            return HiddenDangerInfo;
        }

        public static AccidentInfoListFrm GetAccidentInfoListFrm()
        {
            if (AccidentInfo == null || AccidentInfo.IsDisposed)
            {
                AccidentInfo=new AccidentInfoListFrm();
            }
            return AccidentInfo;
        }

        public static TeamInfoListFrm GeTeamInfoListFrm()
        {
            if (TeamInfo == null || TeamInfo.IsDisposed)
            {
                TeamInfo=new TeamInfoListFrm();
            }
            return TeamInfo;
        }

        public static UnitInfoListFrm GetUnitInfoListFrm()
        {
            if (UnitInfo == null || UnitInfo.IsDisposed)
            {
                UnitInfo=new UnitInfoListFrm();
            }
            return UnitInfo;
        }

        public static UserInfoListFrm GetUserInfoListFrm()
        {
            if (UserInfo == null || UserInfo.IsDisposed)
            {
                UserInfo=new UserInfoListFrm();
            }
            return UserInfo;
        }
    }
}
