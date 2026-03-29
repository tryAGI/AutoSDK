//HintName: G.Models.ProviderUsageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProviderUsageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeSeries", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ProviderUsageTimeSeriesDataPoint> TimeSeries { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("leaderboard", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ProviderUsageLeaderboardEntry> Leaderboard { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderUsageResponse" /> class.
        /// </summary>
        /// <param name="timeSeries"></param>
        /// <param name="leaderboard"></param>
        public ProviderUsageResponse(
            global::System.Collections.Generic.IList<global::G.ProviderUsageTimeSeriesDataPoint> timeSeries,
            global::System.Collections.Generic.IList<global::G.ProviderUsageLeaderboardEntry> leaderboard)
        {
            this.TimeSeries = timeSeries ?? throw new global::System.ArgumentNullException(nameof(timeSeries));
            this.Leaderboard = leaderboard ?? throw new global::System.ArgumentNullException(nameof(leaderboard));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderUsageResponse" /> class.
        /// </summary>
        public ProviderUsageResponse()
        {
        }
    }
}