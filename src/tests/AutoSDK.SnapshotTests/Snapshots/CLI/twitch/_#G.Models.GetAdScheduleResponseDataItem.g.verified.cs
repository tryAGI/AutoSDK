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
        [global::System.Text.Json.Serialization.JsonPropertyName("snooze_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SnoozeCount { get; set; }

        /// <summary>
        /// The UTC timestamp when the broadcaster will gain an additional snooze, in RFC3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snooze_refresh_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime SnoozeRefreshAt { get; set; }

        /// <summary>
        /// The UTC timestamp of the broadcaster’s next scheduled ad, in RFC3339 format. Empty if the channel has no ad scheduled or is not live.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_ad_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime NextAdAt { get; set; }

        /// <summary>
        /// The length in seconds of the scheduled upcoming ad break.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duration { get; set; }

        /// <summary>
        /// The UTC timestamp of the broadcaster’s last ad-break, in RFC3339 format. Empty if the channel has not run an ad or is not live.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_ad_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastAdAt { get; set; }

        /// <summary>
        /// The amount of pre-roll free time remaining for the channel in seconds. Returns 0 if they are currently not pre-roll free.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preroll_free_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PrerollFreeTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAdScheduleResponseDataItem" /> class.
        /// </summary>
        /// <param name="snoozeCount">
        /// The number of snoozes available for the broadcaster.
        /// </param>
        /// <param name="snoozeRefreshAt">
        /// The UTC timestamp when the broadcaster will gain an additional snooze, in RFC3339 format.
        /// </param>
        /// <param name="nextAdAt">
        /// The UTC timestamp of the broadcaster’s next scheduled ad, in RFC3339 format. Empty if the channel has no ad scheduled or is not live.
        /// </param>
        /// <param name="duration">
        /// The length in seconds of the scheduled upcoming ad break.
        /// </param>
        /// <param name="lastAdAt">
        /// The UTC timestamp of the broadcaster’s last ad-break, in RFC3339 format. Empty if the channel has not run an ad or is not live.
        /// </param>
        /// <param name="prerollFreeTime">
        /// The amount of pre-roll free time remaining for the channel in seconds. Returns 0 if they are currently not pre-roll free.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAdScheduleResponseDataItem(
            int snoozeCount,
            global::System.DateTime snoozeRefreshAt,
            global::System.DateTime nextAdAt,
            int duration,
            global::System.DateTime lastAdAt,
            int prerollFreeTime)
        {
            this.SnoozeCount = snoozeCount;
            this.SnoozeRefreshAt = snoozeRefreshAt;
            this.NextAdAt = nextAdAt;
            this.Duration = duration;
            this.LastAdAt = lastAdAt;
            this.PrerollFreeTime = prerollFreeTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAdScheduleResponseDataItem" /> class.
        /// </summary>
        public GetAdScheduleResponseDataItem()
        {
        }
    }
}