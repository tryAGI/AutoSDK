//HintName: G.Models.UpdateChannelStreamScheduleSegmentResponseDataVacation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The dates when the broadcaster is on vacation and not streaming. Is set to **null** if vacation mode is not enabled.
    /// </summary>
    public sealed partial class UpdateChannelStreamScheduleSegmentResponseDataVacation
    {
        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the broadcaster’s vacation starts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the broadcaster’s vacation ends.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelStreamScheduleSegmentResponseDataVacation" /> class.
        /// </summary>
        /// <param name="startTime">
        /// The UTC date and time (in RFC3339 format) of when the broadcaster’s vacation starts.
        /// </param>
        /// <param name="endTime">
        /// The UTC date and time (in RFC3339 format) of when the broadcaster’s vacation ends.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateChannelStreamScheduleSegmentResponseDataVacation(
            global::System.DateTime startTime,
            global::System.DateTime endTime)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelStreamScheduleSegmentResponseDataVacation" /> class.
        /// </summary>
        public UpdateChannelStreamScheduleSegmentResponseDataVacation()
        {
        }
    }
}