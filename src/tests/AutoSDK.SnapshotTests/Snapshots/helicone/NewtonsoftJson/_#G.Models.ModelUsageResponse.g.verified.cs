//HintName: G.Models.ModelUsageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelUsageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeSeries", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ModelUsageTimeSeriesDataPoint> TimeSeries { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("leaderboard", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ModelUsageLeaderboardEntry> Leaderboard { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelUsageResponse" /> class.
        /// </summary>
        /// <param name="timeSeries"></param>
        /// <param name="leaderboard"></param>
        public ModelUsageResponse(
            global::System.Collections.Generic.IList<global::G.ModelUsageTimeSeriesDataPoint> timeSeries,
            global::System.Collections.Generic.IList<global::G.ModelUsageLeaderboardEntry> leaderboard)
        {
            this.TimeSeries = timeSeries ?? throw new global::System.ArgumentNullException(nameof(timeSeries));
            this.Leaderboard = leaderboard ?? throw new global::System.ArgumentNullException(nameof(leaderboard));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelUsageResponse" /> class.
        /// </summary>
        public ModelUsageResponse()
        {
        }
    }
}