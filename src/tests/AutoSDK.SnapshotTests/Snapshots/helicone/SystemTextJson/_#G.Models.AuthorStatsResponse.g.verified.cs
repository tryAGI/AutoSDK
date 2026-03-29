//HintName: G.Models.AuthorStatsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthorStatsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalTokens { get; set; }

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
        /// Initializes a new instance of the <see cref="AuthorStatsResponse" /> class.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="totalTokens"></param>
        /// <param name="timeSeries"></param>
        /// <param name="leaderboard"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthorStatsResponse(
            string author,
            double totalTokens,
            global::System.Collections.Generic.IList<global::G.ModelUsageTimeSeriesDataPoint> timeSeries,
            global::System.Collections.Generic.IList<global::G.ModelUsageLeaderboardEntry> leaderboard)
        {
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.TotalTokens = totalTokens;
            this.TimeSeries = timeSeries ?? throw new global::System.ArgumentNullException(nameof(timeSeries));
            this.Leaderboard = leaderboard ?? throw new global::System.ArgumentNullException(nameof(leaderboard));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorStatsResponse" /> class.
        /// </summary>
        public AuthorStatsResponse()
        {
        }
    }
}