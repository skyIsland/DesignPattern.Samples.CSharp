using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Proxy
{
    /// <summary>
    /// 代理主题类：代理查询
    /// </summary>
    public class ProxySearcher : ISearcher
    {
        private RealSearcher searcher = new RealSearcher(); // 维持一个对真是主题的引用
        private AccessValidator validator;
        private Logger logger;
        private BreadNotic breadNotic;

        public string DoSearch(string userID, string keyword)
        {
            if (Validate(userID))
            {
                string result = searcher.DoSearch(userID, keyword);
                this.Log(userID);
                this.Notic(userID);
                return result;
            }

            return null;
        }

        /// <summary>
        /// 创建访问验证对象并调用其Validate()方法进行身份验证
        /// </summary>
        /// <returns></returns>
        public bool Validate(string userID)
        {
            validator = new AccessValidator();
            return validator.Validate(userID);
        }

        /// <summary>
        /// 创建日志记录器并调用Log()方法实现日志记录
        /// </summary>
        /// <param name="userID"></param>
        public void Log(string userID)
        {
            logger = new Logger();
            logger.Log(userID);
        }

        /// <summary>
        /// 创建通知类并调用Notic()方法实现通知
        /// </summary>
        /// <param name="userID"></param>
        public void Notic(string userID)
        {
            breadNotic = new BreadNotic();
            breadNotic.Notic(userID);
        }
    }
}
