﻿//HintName: G.Models.GuestVideoSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the guest’s video settings
    /// </summary>
    public sealed partial class GuestVideoSettings
    {
        /// <summary>
        /// Flag determining whether the host is allowing the guest’s video to be seen or heard within the session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_host_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsHostEnabled { get; set; } = default!;

        /// <summary>
        /// Flag determining whether the guest is allowing their video to be transmitted to the session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_guest_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsGuestEnabled { get; set; } = default!;

        /// <summary>
        /// Flag determining whether the guest has an appropriate video device available to be transmitted to the session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_available", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsAvailable { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuestVideoSettings" /> class.
        /// </summary>
        /// <param name="isHostEnabled">
        /// Flag determining whether the host is allowing the guest’s video to be seen or heard within the session.
        /// </param>
        /// <param name="isGuestEnabled">
        /// Flag determining whether the guest is allowing their video to be transmitted to the session.
        /// </param>
        /// <param name="isAvailable">
        /// Flag determining whether the guest has an appropriate video device available to be transmitted to the session.
        /// </param>
        public GuestVideoSettings(
            bool isHostEnabled,
            bool isGuestEnabled,
            bool isAvailable)
        {
            this.IsHostEnabled = isHostEnabled;
            this.IsGuestEnabled = isGuestEnabled;
            this.IsAvailable = isAvailable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuestVideoSettings" /> class.
        /// </summary>
        public GuestVideoSettings()
        {
        }
    }
}