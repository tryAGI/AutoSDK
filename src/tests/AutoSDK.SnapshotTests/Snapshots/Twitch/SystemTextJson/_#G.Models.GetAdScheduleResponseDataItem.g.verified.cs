//HintName: G.Models.GetAdScheduleResponseDataItem.g.cs

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


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        public static global::G.GetAdScheduleResponseDataItem? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.GetAdScheduleResponseDataItem),
                jsonSerializerContext) as global::G.GetAdScheduleResponseDataItem;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.GetAdScheduleResponseDataItem? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetAdScheduleResponseDataItem>(
                json,
                jsonSerializerOptions);
        }

    }
}