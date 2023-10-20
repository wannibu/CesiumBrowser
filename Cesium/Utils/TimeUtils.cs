using System;

namespace Cesium.Utils
{
    public static class TimeUtils
    {
        public static string GetTimeElapsed(DateTime dateTime)
        {
            TimeSpan timeSpan = DateTime.Now - dateTime;

            if (timeSpan.TotalSeconds < 1)
                return "刚刚";
            else if (timeSpan.TotalMinutes < 1)
                return $"{Math.Floor(timeSpan.TotalSeconds)}秒前";
            else if (timeSpan.TotalHours < 1)
                return $"{Math.Floor(timeSpan.TotalMinutes)}分钟前";
            else if (timeSpan.TotalDays < 1)
                return $"{Math.Floor(timeSpan.TotalHours)}小时前";
            else
                return $"{Math.Floor(timeSpan.TotalDays)}天前";
        }
    }
}
