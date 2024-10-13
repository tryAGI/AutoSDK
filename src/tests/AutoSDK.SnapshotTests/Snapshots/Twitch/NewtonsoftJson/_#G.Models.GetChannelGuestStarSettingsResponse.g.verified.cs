//HintName: G.Models.GetChannelGuestStarSettingsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetChannelGuestStarSettingsResponse
    {
        /// <summary>
        /// Flag determining if Guest Star moderators have access to control whether a guest is live once assigned to a slot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_moderator_send_live_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsModeratorSendLiveEnabled { get; set; } = default!;

        /// <summary>
        /// Number of slots the Guest Star call interface will allow the host to add to a call. Required to be between 1 and 6.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slot_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int SlotCount { get; set; } = default!;

        /// <summary>
        /// Flag determining if Browser Sources subscribed to sessions on this channel should output audio
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_browser_source_audio_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsBrowserSourceAudioEnabled { get; set; } = default!;

        /// <summary>
        /// This setting determines how the guests within a session should be laid out within the browser source. Can be one of the following values:   <br/>
        ///   <br/>
        /// * `TILED_LAYOUT`: All live guests are tiled within the browser source with the same size.<br/>
        /// * `SCREENSHARE_LAYOUT`: All live guests are tiled within the browser source with the same size. If there is an active screen share, it is sized larger than the other guests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_layout", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetChannelGuestStarSettingsResponseGroupLayout GroupLayout { get; set; } = default!;

        /// <summary>
        /// View only token to generate browser source URLs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("browser_source_token", Required = global::Newtonsoft.Json.Required.Always)]
        public string BrowserSourceToken { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.GetChannelGuestStarSettingsResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetChannelGuestStarSettingsResponse>(
                json,
                jsonSerializerOptions);
        }

    }
}