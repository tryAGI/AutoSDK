//HintName: G.Models.UserMetricsQueryParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserMetricsQueryParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UserFilterNode Filter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset", Required = global::Newtonsoft.Json.Required.Always)]
        public double Offset { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public double Limit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeFilter")]
        public global::G.UserMetricsQueryParamsTimeFilter? TimeFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeZoneDifferenceMinutes")]
        public double? TimeZoneDifferenceMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sort")]
        public global::G.SortLeafUsers? Sort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMetricsQueryParams" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="timeFilter"></param>
        /// <param name="timeZoneDifferenceMinutes"></param>
        /// <param name="sort"></param>
        public UserMetricsQueryParams(
            global::G.UserFilterNode filter,
            double offset,
            double limit,
            global::G.UserMetricsQueryParamsTimeFilter? timeFilter,
            double? timeZoneDifferenceMinutes,
            global::G.SortLeafUsers? sort)
        {
            this.Filter = filter;
            this.Offset = offset;
            this.Limit = limit;
            this.TimeFilter = timeFilter;
            this.TimeZoneDifferenceMinutes = timeZoneDifferenceMinutes;
            this.Sort = sort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMetricsQueryParams" /> class.
        /// </summary>
        public UserMetricsQueryParams()
        {
        }
    }
}