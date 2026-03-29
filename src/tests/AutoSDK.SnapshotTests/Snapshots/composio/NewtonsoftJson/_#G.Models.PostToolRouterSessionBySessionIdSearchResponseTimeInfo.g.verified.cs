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
        [global::Newtonsoft.Json.JsonProperty("current_time_utc", Required = global::Newtonsoft.Json.Required.Always)]
        public string CurrentTimeUtc { get; set; } = default!;

        /// <summary>
        /// Current time as Unix epoch timestamp in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_time_utc_epoch_seconds", Required = global::Newtonsoft.Json.Required.Always)]
        public double CurrentTimeUtcEpochSeconds { get; set; } = default!;

        /// <summary>
        /// Important message about time handling and timezone considerations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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