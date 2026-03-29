//HintName: G.Models.CloudSlackDataSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloudSlackDataSource
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_access_control")]
        public bool? SupportsAccessControl { get; set; }

        /// <summary>
        /// Slack Bot Token.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slack_token")]
        public string? SlackToken { get; set; }

        /// <summary>
        /// Slack Channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_ids")]
        public string? ChannelIds { get; set; }

        /// <summary>
        /// Latest date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_date")]
        public string? LatestDate { get; set; }

        /// <summary>
        /// Earliest date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("earliest_date")]
        public string? EarliestDate { get; set; }

        /// <summary>
        /// Earliest date timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("earliest_date_timestamp")]
        public double? EarliestDateTimestamp { get; set; }

        /// <summary>
        /// Latest date timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_date_timestamp")]
        public double? LatestDateTimestamp { get; set; }

        /// <summary>
        /// Slack Channel name pattern.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_patterns")]
        public string? ChannelPatterns { get; set; }

        /// <summary>
        /// Default Value: CloudSlackDataSource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudSlackDataSource" /> class.
        /// </summary>
        /// <param name="supportsAccessControl">
        /// Default Value: false
        /// </param>
        /// <param name="slackToken">
        /// Slack Bot Token.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="channelIds">
        /// Slack Channel.
        /// </param>
        /// <param name="latestDate">
        /// Latest date.
        /// </param>
        /// <param name="earliestDate">
        /// Earliest date.
        /// </param>
        /// <param name="earliestDateTimestamp">
        /// Earliest date timestamp.
        /// </param>
        /// <param name="latestDateTimestamp">
        /// Latest date timestamp.
        /// </param>
        /// <param name="channelPatterns">
        /// Slack Channel name pattern.
        /// </param>
        /// <param name="className">
        /// Default Value: CloudSlackDataSource
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloudSlackDataSource(
            bool? supportsAccessControl,
            string? slackToken,
            string? channelIds,
            string? latestDate,
            string? earliestDate,
            double? earliestDateTimestamp,
            double? latestDateTimestamp,
            string? channelPatterns,
            string? className)
        {
            this.SupportsAccessControl = supportsAccessControl;
            this.SlackToken = slackToken;
            this.ChannelIds = channelIds;
            this.LatestDate = latestDate;
            this.EarliestDate = earliestDate;
            this.EarliestDateTimestamp = earliestDateTimestamp;
            this.LatestDateTimestamp = latestDateTimestamp;
            this.ChannelPatterns = channelPatterns;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudSlackDataSource" /> class.
        /// </summary>
        public CloudSlackDataSource()
        {
        }
    }
}