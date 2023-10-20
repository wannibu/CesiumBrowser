using SqlSugar;
using System;

namespace Cesium.Tables
{
    [SugarTable("history", "history")]
    public class HistoryModel
    {
        [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime VisitTime { get; set; }
        public int FormVisit { get; set; }
        public byte[] Favicon { get; set; }
    }
}
