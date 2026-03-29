//HintName: G.Models.PostToolRouterSessionBySessionIdSearchResponseTimeInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Time information for the query
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdSearchResponseTimeInfo
    {
        /// <summary>
        /// Current time in ISO format (UTC)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_time_utc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrentTimeUtc { get; set; }

        /// <summary>
        /// Current time as Unix epoch timestamp in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_time_utc_epoch_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CurrentTimeUtcEpochSeconds { get; set; }

        /// <summary>
        /// Important message about time handling and timezone considerations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseTimeInfo" /> class.
        /// </summary>
        /// <param name="currentTimeUtc">
        /// Current time in ISO format (UTC)
        /// </param>
        /// <param name="currentTimeUtcEpochSeconds">
        /// Current time as Unix epoch timestamp in seconds
        /// </param>
        /// <param name="message">
        /// Important message about time handling and timezone considerations
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdSearchResponseTimeInfo(
            string currentTimeUtc,
            double currentTimeUtcEpochSeconds,
            string message)
        {
            this.CurrentTimeUtc = currentTimeUtc ?? throw new global::System.ArgumentNullException(nameof(currentTimeUtc));
            this.CurrentTimeUtcEpochSeconds = currentTimeUtcEpochSeconds;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseTimeInfo" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdSearchResponseTimeInfo()
        {
        }
    }
}