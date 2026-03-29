//HintName: G.Models.ApiProjectsStatsLeadTimeRetrieveResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsStatsLeadTimeRetrieveResponse
    {
        /// <summary>
        /// Lead time statistics including mean, median, and distribution
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lead_time_stats")]
        public global::System.Collections.Generic.IList<global::G.ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat>? LeadTimeStats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsLeadTimeRetrieveResponse" /> class.
        /// </summary>
        /// <param name="leadTimeStats">
        /// Lead time statistics including mean, median, and distribution
        /// </param>
        public ApiProjectsStatsLeadTimeRetrieveResponse(
            global::System.Collections.Generic.IList<global::G.ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat>? leadTimeStats)
        {
            this.LeadTimeStats = leadTimeStats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsLeadTimeRetrieveResponse" /> class.
        /// </summary>
        public ApiProjectsStatsLeadTimeRetrieveResponse()
        {
        }
    }
}