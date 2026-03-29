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
        [global::System.Text.Json.Serialization.JsonPropertyName("timeSeries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ModelUsageTimeSeriesDataPoint> TimeSeries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaderboard")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ModelUsageLeaderboardEntry> Leaderboard { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelUsageResponse" /> class.
        /// </summary>
        /// <param name="timeSeries"></param>
        /// <param name="leaderboard"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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