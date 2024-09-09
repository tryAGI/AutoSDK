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
        [global::Newtonsoft.Json.JsonProperty("is_host_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsHostEnabled { get; set; } = default!;

        /// <summary>
        /// Flag determining whether the guest is allowing their audio to be transmitted to the session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_guest_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsGuestEnabled { get; set; } = default!;

        /// <summary>
        /// Flag determining whether the guest has an appropriate audio device available to be transmitted to the session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_available", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsAvailable { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}