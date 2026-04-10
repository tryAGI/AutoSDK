//HintName: G.Models.AdminUsageReportData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Contains the detailed usage statistics for the specified date range.
    /// </summary>
    public sealed partial class AdminUsageReportData
    {
        /// <summary>
        /// Breakdown of character usage by category.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_usage")]
        public global::G.UsageBreakdown? TotalUsage { get; set; }

        /// <summary>
        /// Start date of the usage report period.<br/>
        /// Example: 2025-09-29T00:00:00
        /// </summary>
        /// <example>2025-09-29T00:00:00</example>
        [global::Newtonsoft.Json.JsonProperty("start_date")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// End date of the usage report period.<br/>
        /// Example: 2025-10-01T00:00:00
        /// </summary>
        /// <example>2025-10-01T00:00:00</example>
        [global::Newtonsoft.Json.JsonProperty("end_date")]
        public global::System.DateTime? EndDate { get; set; }

        /// <summary>
        /// The grouping method used, if any.<br/>
        /// Example: key_and_day
        /// </summary>
        /// <example>key_and_day</example>
        [global::Newtonsoft.Json.JsonProperty("group_by")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AdminUsageReportDataGroupByJsonConverter))]
        public global::G.AdminUsageReportDataGroupBy? GroupBy { get; set; }

        /// <summary>
        /// Usage statistics grouped by key. Present when group_by='key'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key_usages")]
        public global::System.Collections.Generic.IList<global::G.KeyUsageItem>? KeyUsages { get; set; }

        /// <summary>
        /// Usage statistics grouped by key and day. Present when group_by='key_and_day'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key_and_day_usages")]
        public global::System.Collections.Generic.IList<global::G.KeyAndDayUsageItem>? KeyAndDayUsages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminUsageReportData" /> class.
        /// </summary>
        /// <param name="totalUsage">
        /// Breakdown of character usage by category.
        /// </param>
        /// <param name="startDate">
        /// Start date of the usage report period.<br/>
        /// Example: 2025-09-29T00:00:00
        /// </param>
        /// <param name="endDate">
        /// End date of the usage report period.<br/>
        /// Example: 2025-10-01T00:00:00
        /// </param>
        /// <param name="groupBy">
        /// The grouping method used, if any.<br/>
        /// Example: key_and_day
        /// </param>
        /// <param name="keyUsages">
        /// Usage statistics grouped by key. Present when group_by='key'.
        /// </param>
        /// <param name="keyAndDayUsages">
        /// Usage statistics grouped by key and day. Present when group_by='key_and_day'.
        /// </param>
        public AdminUsageReportData(
            global::G.UsageBreakdown? totalUsage,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            global::G.AdminUsageReportDataGroupBy? groupBy,
            global::System.Collections.Generic.IList<global::G.KeyUsageItem>? keyUsages,
            global::System.Collections.Generic.IList<global::G.KeyAndDayUsageItem>? keyAndDayUsages)
        {
            this.TotalUsage = totalUsage;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.GroupBy = groupBy;
            this.KeyUsages = keyUsages;
            this.KeyAndDayUsages = keyAndDayUsages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminUsageReportData" /> class.
        /// </summary>
        public AdminUsageReportData()
        {
        }
    }
}