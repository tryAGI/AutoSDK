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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the broadcast starts.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartTime { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the broadcast ends.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime EndTime { get; set; } = default!;

        /// <summary>
        /// The broadcast segment’s title.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Indicates whether the broadcaster canceled this segment of a recurring broadcast. If the broadcaster canceled this segment, this field is set to the same value that’s in the `end_time` field; otherwise, it’s set to **null**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("canceled_until", Required = global::Newtonsoft.Json.Required.Always)]
        public string? CanceledUntil { get; set; } = default!;

        /// <summary>
        /// The type of content that the broadcaster plans to stream or **null** if not specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChannelStreamScheduleSegmentCategory Category { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the broadcast is part of a recurring series that streams at the same time each week or is a one-time broadcast. Is **true** if the broadcast is part of a recurring series.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_recurring", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsRecurring { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelStreamScheduleSegment" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that identifies this broadcast segment.
        /// </param>
        /// <param name="startTime">
        /// The UTC date and time (in RFC3339 format) of when the broadcast starts.
        /// </param>
        /// <param name="endTime">
        /// The UTC date and time (in RFC3339 format) of when the broadcast ends.
        /// </param>
        /// <param name="title">
        /// The broadcast segment’s title.
        /// </param>
        /// <param name="canceledUntil">
        /// Indicates whether the broadcaster canceled this segment of a recurring broadcast. If the broadcaster canceled this segment, this field is set to the same value that’s in the `end_time` field; otherwise, it’s set to **null**.
        /// </param>
        /// <param name="category">
        /// The type of content that the broadcaster plans to stream or **null** if not specified.
        /// </param>
        /// <param name="isRecurring">
        /// A Boolean value that determines whether the broadcast is part of a recurring series that streams at the same time each week or is a one-time broadcast. Is **true** if the broadcast is part of a recurring series.
        /// </param>
        public ChannelStreamScheduleSegment(
            string id,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            string title,
            string? canceledUntil,
            global::G.ChannelStreamScheduleSegmentCategory category,
            bool isRecurring)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.CanceledUntil = canceledUntil ?? throw new global::System.ArgumentNullException(nameof(canceledUntil));
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.IsRecurring = isRecurring;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelStreamScheduleSegment" /> class.
        /// </summary>
        public ChannelStreamScheduleSegment()
        {
        }
    }
}