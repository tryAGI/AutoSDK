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
    }
}