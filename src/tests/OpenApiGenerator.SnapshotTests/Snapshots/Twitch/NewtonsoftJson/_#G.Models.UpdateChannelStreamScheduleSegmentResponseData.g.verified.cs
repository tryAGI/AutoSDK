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
        [global::Newtonsoft.Json.JsonProperty("segments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<ChannelStreamScheduleSegment> Segments { get; set; } = default!;

        /// <summary>
        /// The ID of the broadcaster that owns the broadcast schedule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterName { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterLogin { get; set; } = default!;

        /// <summary>
        /// The dates when the broadcaster is on vacation and not streaming. Is set to **null** if vacation mode is not enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vacation", Required = global::Newtonsoft.Json.Required.Always)]
        public UpdateChannelStreamScheduleSegmentResponseDataVacation Vacation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}