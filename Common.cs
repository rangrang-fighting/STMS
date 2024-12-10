using System.Collections.Generic;

namespace SCMS
{
    /// <summary>
    /// 公共类
    /// </summary>
    public class Common
    {
        /// <summary>
        /// 性别
        /// </summary>
        public  static List<string> SexList
        {
            get
            {
             string[] sl = { "保密", "男", "女" };
                List<string> sexList = new List<string>();
                for(int i = 0; i < sl.Length; i++)
                {
                    sexList.Add(sl[i]);
                }
                return sexList;
            }
        }
        /// <summary>
        /// 用户级别
        /// </summary>
        public static List<string> UserLevelList
        { 
            get
            {
                string[] sl = { "管理员", "老师", "学生" };
                List<string> sexList = new List<string>();
                for (int i = 0; i < sl.Length; i++)
                {
                    sexList.Add(sl[i]);
                }
                return sexList;
            }
        }
    }
}
