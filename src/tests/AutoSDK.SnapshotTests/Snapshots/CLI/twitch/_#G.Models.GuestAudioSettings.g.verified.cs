//HintName: G.Models.GuestAudioSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the guest’s audio settings
    /// </summary>
    public sealed partial class GuestAudioSettings
    {
        /// <summary>
        /// Flag determining whether the host is allowing the guest’s audio to be seen or heard within the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_host_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsHostEnabled { get; set; }

        /// <summary>
        /// Flag determining whether the guest is allowing their audio to be transmitted to the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_guest_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsGuestEnabled { get; set; }

        /// <summary>
        /// Flag determining whether the guest has an appropriate audio device available to be transmitted to the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAvailable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuestAudioSettings" /> class.
        /// </summary>
        /// <param name="isHostEnabled">
        /// Flag determining whether the host is allowing the guest’s audio to be seen or heard within the session.
        /// </param>
        /// <param name="isGuestEnabled">
        /// Flag determining whether the guest is allowing their audio to be transmitted to the session.
        /// </param>
        /// <param name="isAvailable">
        /// Flag determining whether the guest has an appropriate audio device available to be transmitted to the session.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuestAudioSettings(
            bool isHostEnabled,
            bool isGuestEnabled,
            bool isAvailable)
        {
            this.IsHostEnabled = isHostEnabled;
            this.IsGuestEnabled = isGuestEnabled;
            this.IsAvailable = isAvailable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuestAudioSettings" /> class.
        /// </summary>
        public GuestAudioSettings()
        {
        }
    }
}