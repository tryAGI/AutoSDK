//HintName: G.Models.UserMetricsQueryParamsTimeFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserMetricsQueryParamsTimeFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTimeUnixSeconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndTimeUnixSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTimeUnixSeconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartTimeUnixSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMetricsQueryParamsTimeFilter" /> class.
        /// </summary>
        /// <param name="endTimeUnixSeconds"></param>
        /// <param name="startTimeUnixSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserMetricsQueryParamsTimeFilter(
            double endTimeUnixSeconds,
            double startTimeUnixSeconds)
        {
            this.EndTimeUnixSeconds = endTimeUnixSeconds;
            this.StartTimeUnixSeconds = startTimeUnixSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMetricsQueryParamsTimeFilter" /> class.
        /// </summary>
        public UserMetricsQueryParamsTimeFilter()
        {
        }
    }
}