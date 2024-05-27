//HintName: G.Models.UpdateChannelStreamScheduleSegmentResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The broadcaster’s streaming scheduled.
    /// </summary>
    public sealed partial class UpdateChannelStreamScheduleSegmentResponseData
    {
        /// <summary>
        /// A list that contains the single broadcast segment that you updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<ChannelStreamScheduleSegment> Segments { get; set; }

        /// <summary>
        /// The ID of the broadcaster that owns the broadcast schedule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterName { get; set; }

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterLogin { get; set; }

        /// <summary>
        /// The dates when the broadcaster is on vacation and not streaming. Is set to **null** if vacation mode is not enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vacation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required UpdateChannelStreamScheduleSegmentResponseDataVacation Vacation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}