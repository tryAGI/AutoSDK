﻿//HintName: G.Models.GetAdScheduleResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAdScheduleResponseDataItem
    {
        /// <summary>
        /// The number of snoozes available for the broadcaster.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("snooze_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int SnoozeCount { get; set; } = default!;

        /// <summary>
        /// The UTC timestamp when the broadcaster will gain an additional snooze, in RFC3339 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("snooze_refresh_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime SnoozeRefreshAt { get; set; } = default!;

        /// <summary>
        /// The UTC timestamp of the broadcaster’s next scheduled ad, in RFC3339 format. Empty if the channel has no ad scheduled or is not live.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_ad_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime NextAdAt { get; set; } = default!;

        /// <summary>
        /// The length in seconds of the scheduled upcoming ad break.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public int Duration { get; set; } = default!;

        /// <summary>
        /// The UTC timestamp of the broadcaster’s last ad-break, in RFC3339 format. Empty if the channel has not run an ad or is not live.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_ad_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime LastAdAt { get; set; } = default!;

        /// <summary>
        /// The amount of pre-roll free time remaining for the channel in seconds. Returns 0 if they are currently not pre-roll free.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preroll_free_time", Required = global::Newtonsoft.Json.Required.Always)]
        public int PrerollFreeTime { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}