using DingTalk.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using yanjiuyuanWeb.Models;

namespace yanjiuyuanWeb.Controllers
{
    /// <summary>
    /// 留言板模块
    /// </summary>
    [RoutePrefix("LeaveWord")]
    public class LeaveWordController : ApiController
    {
        /// <summary>
        /// 留言保存
        /// </summary>
        /// <param name="ReceivingList"></param>
        /// <returns></returns>
        [Route("Save")]
        [HttpPost]
        public object SaveTable([FromBody] LeaveWord leaveWord)
        {
            try
            {
                EFHelper<LeaveWord> eFHelper = new EFHelper<LeaveWord>();
                eFHelper.Add(leaveWord);
                return new NewErrorModel()
                {
                    error = new Error(0, "保存成功！", "") { },
                };
            }
            catch (Exception ex)
            {
                return new NewErrorModel()
                {
                    error = new Error(1, ex.Message, "") { },
                };
            }
        }

        /// <summary>
        /// 留言读取
        /// </summary>
        /// <returns></returns>
        [Route("Read")]
        [HttpGet]
        public object SaveTable()
        {
            try
            {
                EFHelper<LeaveWord> eFHelper = new EFHelper<LeaveWord>();
                List<LeaveWord> leaveWords = eFHelper.GetList();
                return new NewErrorModel()
                {
                    data = leaveWords,
                    error = new Error(0, "读取成功！", "") { },
                };
            }
            catch (Exception ex)
            {
                return new NewErrorModel()
                {
                    error = new Error(1, ex.Message, "") { },
                };
            }
        }
    }
}
