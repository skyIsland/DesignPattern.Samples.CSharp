using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Proxy
{
    /// <summary>
    /// 业务类：通知类
    /// </summary>
    public class BreadNotic
    {
        /// <summary>
        /// 模拟实现通知
        /// </summary>
        /// <param name="userID"></param>
        public void Notic(string userID)
        {
            Console.WriteLine("通知，用户 {0} 使用查询功能!", userID);
        }
    }
}
