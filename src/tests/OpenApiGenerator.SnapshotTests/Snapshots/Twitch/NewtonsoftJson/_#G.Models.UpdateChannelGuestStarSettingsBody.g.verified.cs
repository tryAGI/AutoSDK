//HintName: G.Models.UpdateChannelGuestStarSettingsBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateChannelGuestStarSettingsBody
    {
        /// <summary>
        /// Flag determining if Guest Star moderators have access to control whether a guest is live once assigned to a slot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_moderator_send_live_enabled")]
        public bool IsModeratorSendLiveEnabled { get; set; }

        /// <summary>
        /// Number of slots the Guest Star call interface will allow the host to add to a call. Required to be between 1 and 6.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slot_count")]
        public int SlotCount { get; set; }

        /// <summary>
        /// Flag determining if Browser Sources subscribed to sessions on this channel should output audio
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_browser_source_audio_enabled")]
        public bool IsBrowserSourceAudioEnabled { get; set; }

        /// <summary>
        /// This setting determines how the guests within a session should be laid out within the browser source. Can be one of the following values:   
        ///   
        /// * `TILED_LAYOUT`: All live guests are tiled within the browser source with the same size.
        /// * `SCREENSHARE_LAYOUT`: All live guests are tiled within the browser source with the same size. If there is an active screen share, it is sized larger than the other guests.
        /// * `HORIZONTAL_LAYOUT`: All live guests are arranged in a horizontal bar within the browser source
        /// * `VERTICAL_LAYOUT`: All live guests are arranged in a vertical bar within the browser source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_layout")]
        public UpdateChannelGuestStarSettingsBodyGroupLayout? GroupLayout { get; set; }

        /// <summary>
        /// Flag determining if Guest Star should regenerate the auth token associated with the channel’s browser sources. Providing a true value for this will immediately invalidate all browser sources previously configured in your streaming software.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("regenerate_browser_sources")]
        public bool RegenerateBrowserSources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}