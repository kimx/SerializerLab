using SerializerLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NTX.SysCore.Services.Domain
{
    [Serializable]
    /// <summary>
    /// 讀取使用者已授權的選單
    /// </summary>
    public partial class UserMenuInfo : BaseInfo
    {
        public string PRG_NO { get; set; }
        public string PRG_NAME { get; set; }
        public string PRG_TYPE { get; set; }
        public string PRG_AREA { get; set; }
        public string MVC_CTRL { get; set; }
        public string MVC_ACT { get; set; }
        public string ENT_POINT { get; set; }
        public string PARAM_VAL { get; set; }
        public int ORDERNUM { get; set; }
        public string UP_PRGNO { get; set; }
        public int PRG_LEVEL { get; set; }
        public string ROOT_PATH { get; set; }
        public string PARENT_PATH { get; set; }
        public string PRG_PATH { get; set; }


    }
}
