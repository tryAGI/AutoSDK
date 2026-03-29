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
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UserFilterNodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UserFilterNode Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeFilter")]
        public global::G.UserMetricsQueryParamsTimeFilter? TimeFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeZoneDifferenceMinutes")]
        public double? TimeZoneDifferenceMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        public global::G.SortLeafUsers? Sort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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