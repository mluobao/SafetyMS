using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZhuGuan.AnQuan.BLLFactory;
using ZhuGuan.AnQuan.DALFactory;
using ZhuGuan.AnQuan.IBLL;
using ZhuGuan.AnQuan.Model.Enum;

namespace ZhuGuan.AnQuan.UI.Portal
{
    public partial class BaseFrm : Form
    {

        public short DelFlagNormal = (short)DelFlagEnum.Normal;

        public BaseFrm()
        {
            InitializeComponent();
        }
        public IServiceSession ServiceSession
        {
            get { return ServiceSessionFactory.GetCurrentServiceSession(); }
        }
    }
}
