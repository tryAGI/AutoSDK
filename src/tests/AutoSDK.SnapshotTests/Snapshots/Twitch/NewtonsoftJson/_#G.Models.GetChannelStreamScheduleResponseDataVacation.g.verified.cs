//HintName: G.Models.GetChannelStreamScheduleResponseDataVacation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The dates when the broadcaster is on vacation and not streaming. Is set to **null** if vacation mode is not enabled.
    /// </summary>
    public sealed partial class GetChannelStreamScheduleResponseDataVacation
    {
        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the broadcaster’s vacation starts.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartTime { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the broadcaster’s vacation ends.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime EndTime { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}