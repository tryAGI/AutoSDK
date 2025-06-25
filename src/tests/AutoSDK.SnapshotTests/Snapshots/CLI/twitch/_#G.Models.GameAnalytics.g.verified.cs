//HintName: G.Models.GameAnalytics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameAnalytics
    {
        /// <summary>
        /// An ID that identifies the game that the report was generated for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("game_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GameId { get; set; }

        /// <summary>
        /// The URL that you use to download the report. The URL is valid for 5 minutes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("URL")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string URL { get; set; }

        /// <summary>
        /// The type of report.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The reporting window’s start and end dates, in RFC3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_range")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GameAnalyticsDateRange DateRange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameAnalytics" /> class.
        /// </summary>
        /// <param name="gameId">
        /// An ID that identifies the game that the report was generated for.
        /// </param>
        /// <param name="uRL">
        /// The URL that you use to download the report. The URL is valid for 5 minutes.
        /// </param>
        /// <param name="type">
        /// The type of report.
        /// </param>
        /// <param name="dateRange">
        /// The reporting window’s start and end dates, in RFC3339 format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameAnalytics(
            string gameId,
            string uRL,
            string type,
            global::G.GameAnalyticsDateRange dateRange)
        {
            this.GameId = gameId ?? throw new global::System.ArgumentNullException(nameof(gameId));
            this.URL = uRL ?? throw new global::System.ArgumentNullException(nameof(uRL));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.DateRange = dateRange ?? throw new global::System.ArgumentNullException(nameof(dateRange));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameAnalytics" /> class.
        /// </summary>
        public GameAnalytics()
        {
        }
    }
}