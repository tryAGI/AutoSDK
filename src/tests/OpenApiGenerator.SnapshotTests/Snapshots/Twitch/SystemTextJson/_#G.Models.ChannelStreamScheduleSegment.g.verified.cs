//HintName: G.Models.ChannelStreamScheduleSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChannelStreamScheduleSegment
    {
        /// <summary>
        /// An ID that identifies this broadcast segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the broadcast starts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the broadcast ends.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        /// The broadcast segment’s title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Indicates whether the broadcaster canceled this segment of a recurring broadcast. If the broadcaster canceled this segment, this field is set to the same value that’s in the `end_time` field; otherwise, it’s set to **null**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceled_until")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? CanceledUntil { get; set; }

        /// <summary>
        /// The type of content that the broadcaster plans to stream or **null** if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChannelStreamScheduleSegmentCategory Category { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the broadcast is part of a recurring series that streams at the same time each week or is a one-time broadcast. Is **true** if the broadcast is part of a recurring series.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_recurring")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsRecurring { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}