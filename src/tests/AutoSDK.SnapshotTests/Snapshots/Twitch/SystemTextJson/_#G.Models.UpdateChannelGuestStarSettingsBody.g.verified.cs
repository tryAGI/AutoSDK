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
        [global::System.Text.Json.Serialization.JsonPropertyName("is_moderator_send_live_enabled")]
        public bool? IsModeratorSendLiveEnabled { get; set; }

        /// <summary>
        /// Number of slots the Guest Star call interface will allow the host to add to a call. Required to be between 1 and 6.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slot_count")]
        public int? SlotCount { get; set; }

        /// <summary>
        /// Flag determining if Browser Sources subscribed to sessions on this channel should output audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_browser_source_audio_enabled")]
        public bool? IsBrowserSourceAudioEnabled { get; set; }

        /// <summary>
        /// This setting determines how the guests within a session should be laid out within the browser source. Can be one of the following values:   <br/>
        ///   <br/>
        /// * `TILED_LAYOUT`: All live guests are tiled within the browser source with the same size.<br/>
        /// * `SCREENSHARE_LAYOUT`: All live guests are tiled within the browser source with the same size. If there is an active screen share, it is sized larger than the other guests.<br/>
        /// * `HORIZONTAL_LAYOUT`: All live guests are arranged in a horizontal bar within the browser source<br/>
        /// * `VERTICAL_LAYOUT`: All live guests are arranged in a vertical bar within the browser source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_layout")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateChannelGuestStarSettingsBodyGroupLayoutJsonConverter))]
        public global::G.UpdateChannelGuestStarSettingsBodyGroupLayout? GroupLayout { get; set; }

        /// <summary>
        /// Flag determining if Guest Star should regenerate the auth token associated with the channel’s browser sources. Providing a true value for this will immediately invalidate all browser sources previously configured in your streaming software.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regenerate_browser_sources")]
        public bool? RegenerateBrowserSources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelGuestStarSettingsBody" /> class.
        /// </summary>
        /// <param name="isModeratorSendLiveEnabled">
        /// Flag determining if Guest Star moderators have access to control whether a guest is live once assigned to a slot.
        /// </param>
        /// <param name="slotCount">
        /// Number of slots the Guest Star call interface will allow the host to add to a call. Required to be between 1 and 6.
        /// </param>
        /// <param name="isBrowserSourceAudioEnabled">
        /// Flag determining if Browser Sources subscribed to sessions on this channel should output audio
        /// </param>
        /// <param name="groupLayout">
        /// This setting determines how the guests within a session should be laid out within the browser source. Can be one of the following values:   <br/>
        ///   <br/>
        /// * `TILED_LAYOUT`: All live guests are tiled within the browser source with the same size.<br/>
        /// * `SCREENSHARE_LAYOUT`: All live guests are tiled within the browser source with the same size. If there is an active screen share, it is sized larger than the other guests.<br/>
        /// * `HORIZONTAL_LAYOUT`: All live guests are arranged in a horizontal bar within the browser source<br/>
        /// * `VERTICAL_LAYOUT`: All live guests are arranged in a vertical bar within the browser source
        /// </param>
        /// <param name="regenerateBrowserSources">
        /// Flag determining if Guest Star should regenerate the auth token associated with the channel’s browser sources. Providing a true value for this will immediately invalidate all browser sources previously configured in your streaming software.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateChannelGuestStarSettingsBody(
            bool? isModeratorSendLiveEnabled,
            int? slotCount,
            bool? isBrowserSourceAudioEnabled,
            global::G.UpdateChannelGuestStarSettingsBodyGroupLayout? groupLayout,
            bool? regenerateBrowserSources)
        {
            this.IsModeratorSendLiveEnabled = isModeratorSendLiveEnabled;
            this.SlotCount = slotCount;
            this.IsBrowserSourceAudioEnabled = isBrowserSourceAudioEnabled;
            this.GroupLayout = groupLayout;
            this.RegenerateBrowserSources = regenerateBrowserSources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelGuestStarSettingsBody" /> class.
        /// </summary>
        public UpdateChannelGuestStarSettingsBody()
        {
        }
    }
}