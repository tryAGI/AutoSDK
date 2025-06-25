﻿//HintName: G.Models.Guest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Guest
    {
        /// <summary>
        /// ID representing this guest’s slot assignment.   <br/>
        ///   <br/>
        /// * Host is always in slot "0"<br/>
        /// * Guests are assigned the following consecutive IDs (e.g, "1", "2", "3", etc)<br/>
        /// * Screen Share is represented as a special guest with the ID "SCREENSHARE"<br/>
        /// * The identifier here matches the ID referenced in browser source links used in broadcasting software.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slot_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SlotId { get; set; }

        /// <summary>
        /// Flag determining whether or not the guest is visible in the browser source in the host’s streaming software.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_live")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsLive { get; set; }

        /// <summary>
        /// User ID of the guest assigned to this slot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Display name of the guest assigned to this slot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserDisplayName { get; set; }

        /// <summary>
        /// Login of the guest assigned to this slot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserLogin { get; set; }

        /// <summary>
        /// Value from 0 to 100 representing the host’s volume setting for this guest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Volume { get; set; }

        /// <summary>
        /// Timestamp when this guest was assigned a slot in the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AssignedAt { get; set; }

        /// <summary>
        /// Information about the guest’s audio settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GuestAudioSettings AudioSettings { get; set; }

        /// <summary>
        /// Information about the guest’s video settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GuestVideoSettings VideoSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Guest" /> class.
        /// </summary>
        /// <param name="slotId">
        /// ID representing this guest’s slot assignment.   <br/>
        ///   <br/>
        /// * Host is always in slot "0"<br/>
        /// * Guests are assigned the following consecutive IDs (e.g, "1", "2", "3", etc)<br/>
        /// * Screen Share is represented as a special guest with the ID "SCREENSHARE"<br/>
        /// * The identifier here matches the ID referenced in browser source links used in broadcasting software.
        /// </param>
        /// <param name="isLive">
        /// Flag determining whether or not the guest is visible in the browser source in the host’s streaming software.
        /// </param>
        /// <param name="userId">
        /// User ID of the guest assigned to this slot.
        /// </param>
        /// <param name="userDisplayName">
        /// Display name of the guest assigned to this slot.
        /// </param>
        /// <param name="userLogin">
        /// Login of the guest assigned to this slot.
        /// </param>
        /// <param name="volume">
        /// Value from 0 to 100 representing the host’s volume setting for this guest.
        /// </param>
        /// <param name="assignedAt">
        /// Timestamp when this guest was assigned a slot in the session.
        /// </param>
        /// <param name="audioSettings">
        /// Information about the guest’s audio settings
        /// </param>
        /// <param name="videoSettings">
        /// Information about the guest’s video settings
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Guest(
            string slotId,
            bool isLive,
            string userId,
            string userDisplayName,
            string userLogin,
            int volume,
            global::System.DateTime assignedAt,
            global::G.GuestAudioSettings audioSettings,
            global::G.GuestVideoSettings videoSettings)
        {
            this.SlotId = slotId ?? throw new global::System.ArgumentNullException(nameof(slotId));
            this.IsLive = isLive;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserDisplayName = userDisplayName ?? throw new global::System.ArgumentNullException(nameof(userDisplayName));
            this.UserLogin = userLogin ?? throw new global::System.ArgumentNullException(nameof(userLogin));
            this.Volume = volume;
            this.AssignedAt = assignedAt;
            this.AudioSettings = audioSettings ?? throw new global::System.ArgumentNullException(nameof(audioSettings));
            this.VideoSettings = videoSettings ?? throw new global::System.ArgumentNullException(nameof(videoSettings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Guest" /> class.
        /// </summary>
        public Guest()
        {
        }
    }
}