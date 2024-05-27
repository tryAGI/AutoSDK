//HintName: G.Models.SnoozeNextAdResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SnoozeNextAdResponseData
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
        /// The UTC timestamp of the broadcaster’s next scheduled ad, in RFC3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_ad_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime NextAdAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}