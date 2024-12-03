//HintName: G.Models.GuestStarInvite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuestStarInvite
    {
        /// <summary>
        /// Twitch User ID corresponding to the invited guest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Timestamp when this user was invited to the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invited_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime InvitedAt { get; set; }

        /// <summary>
        /// Status representing the invited user’s join state. Can be one of the following:   <br/>
        ///   <br/>
        /// * `INVITED`: The user has been invited to the session but has not acknowledged it.<br/>
        /// * `ACCEPTED`: The invited user has acknowledged the invite and joined the waiting room, but may still be setting up their media devices or otherwise preparing to join the call.<br/>
        /// * `READY`: The invited user has signaled they are ready to join the call from the waiting room.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Flag signaling that the invited user has chosen to disable their local video device. The user has hidden themselves, but they may choose to reveal their video feed upon joining the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_video_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsVideoEnabled { get; set; }

        /// <summary>
        /// Flag signaling that the invited user has chosen to disable their local audio device. The user has muted themselves, but they may choose to unmute their audio feed upon joining the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_audio_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAudioEnabled { get; set; }

        /// <summary>
        /// Flag signaling that the invited user has a video device available for sharing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_video_available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsVideoAvailable { get; set; }

        /// <summary>
        /// Flag signaling that the invited user has an audio device available for sharing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_audio_available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAudioAvailable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuestStarInvite" /> class.
        /// </summary>
        /// <param name="userId">
        /// Twitch User ID corresponding to the invited guest
        /// </param>
        /// <param name="invitedAt">
        /// Timestamp when this user was invited to the session.
        /// </param>
        /// <param name="status">
        /// Status representing the invited user’s join state. Can be one of the following:   <br/>
        ///   <br/>
        /// * `INVITED`: The user has been invited to the session but has not acknowledged it.<br/>
        /// * `ACCEPTED`: The invited user has acknowledged the invite and joined the waiting room, but may still be setting up their media devices or otherwise preparing to join the call.<br/>
        /// * `READY`: The invited user has signaled they are ready to join the call from the waiting room.
        /// </param>
        /// <param name="isVideoEnabled">
        /// Flag signaling that the invited user has chosen to disable their local video device. The user has hidden themselves, but they may choose to reveal their video feed upon joining the session.
        /// </param>
        /// <param name="isAudioEnabled">
        /// Flag signaling that the invited user has chosen to disable their local audio device. The user has muted themselves, but they may choose to unmute their audio feed upon joining the session.
        /// </param>
        /// <param name="isVideoAvailable">
        /// Flag signaling that the invited user has a video device available for sharing.
        /// </param>
        /// <param name="isAudioAvailable">
        /// Flag signaling that the invited user has an audio device available for sharing.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GuestStarInvite(
            string userId,
            global::System.DateTime invitedAt,
            string status,
            bool isVideoEnabled,
            bool isAudioEnabled,
            bool isVideoAvailable,
            bool isAudioAvailable)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.InvitedAt = invitedAt;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.IsVideoEnabled = isVideoEnabled;
            this.IsAudioEnabled = isAudioEnabled;
            this.IsVideoAvailable = isVideoAvailable;
            this.IsAudioAvailable = isAudioAvailable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuestStarInvite" /> class.
        /// </summary>
        public GuestStarInvite()
        {
        }
    }
}