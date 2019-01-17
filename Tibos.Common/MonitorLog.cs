﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace Tibos.Common
{
    public class MonitorLog
    {
        public string ControllerName
        {
            get;
            set;
        }
        public string ActionName
        {
            get;
            set;
        }
        public DateTime ExecuteStartTime
        {
            get;
            set;
        }
        public DateTime ExecuteEndTime
        {
            get;
            set;
        }
        /// <summary>
        /// 耗时（s）
        /// </summary>
        public double TimeConsuming { get; set; }

        /// <summary>
        /// Body
        /// </summary>
        public string BodyCollections
        {
            get;
            set;
        }
        /// <summary>
        /// URL 参数
        /// </summary>
        public QueryString QueryCollections
        {
            get;
            set;
        }
        /// <summary>
        /// 监控类型
        /// </summary>
        public enum MonitorType
        {
            Action = 1,
            View = 2
        }
        /// <summary>
        /// 获取监控指标日志
        /// </summary>
        /// <param name="mtype"></param>
        /// <returns></returns>
        public string GetLoginfo(MonitorType mtype = MonitorType.Action)
        {
            string ActionView = "Tibos执行时间监控";
            string Name = "Action";
            if (mtype == MonitorType.View)
            {
                ActionView = "View视图生成时间监控";
                Name = "View";
            }
            var res = $"\n---------------------------------->{ActionView}<----------------------------------\n----------------->ControllerName：{ControllerName}Controller\n----------------->ActionName：{ActionName}\n----------------->开始时间：{ExecuteStartTime}\n----------------->结束时间：{ExecuteEndTime}\n----------------->Form表单数据：{BodyCollections}\n----------------->URL参数：{QueryCollections.ToString()}\n----------------->耗时：{TimeConsuming}秒";
            return res;
          
        }
    }
}
