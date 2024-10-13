//HintName: G.Models.Guest.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("slot_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SlotId { get; set; } = default!;

        /// <summary>
        /// Flag determining whether or not the guest is visible in the browser source in the host’s streaming software.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_live", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsLive { get; set; } = default!;

        /// <summary>
        /// User ID of the guest assigned to this slot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// Display name of the guest assigned to this slot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserDisplayName { get; set; } = default!;

        /// <summary>
        /// Login of the guest assigned to this slot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserLogin { get; set; } = default!;

        /// <summary>
        /// Value from 0 to 100 representing the host’s volume setting for this guest.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("volume", Required = global::Newtonsoft.Json.Required.Always)]
        public int Volume { get; set; } = default!;

        /// <summary>
        /// Timestamp when this guest was assigned a slot in the session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assigned_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime AssignedAt { get; set; } = default!;

        /// <summary>
        /// Information about the guest’s audio settings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_settings", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GuestAudioSettings AudioSettings { get; set; } = default!;

        /// <summary>
        /// Information about the guest’s video settings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_settings", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GuestVideoSettings VideoSettings { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
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

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Guest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Guest>(
                json,
                jsonSerializerOptions);
        }

    }
}