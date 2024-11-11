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
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// Timestamp when this user was invited to the session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invited_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime InvitedAt { get; set; } = default!;

        /// <summary>
        /// Status representing the invited user’s join state. Can be one of the following:   <br/>
        ///   <br/>
        /// * `INVITED`: The user has been invited to the session but has not acknowledged it.<br/>
        /// * `ACCEPTED`: The invited user has acknowledged the invite and joined the waiting room, but may still be setting up their media devices or otherwise preparing to join the call.<br/>
        /// * `READY`: The invited user has signaled they are ready to join the call from the waiting room.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Flag signaling that the invited user has chosen to disable their local video device. The user has hidden themselves, but they may choose to reveal their video feed upon joining the session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_video_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsVideoEnabled { get; set; } = default!;

        /// <summary>
        /// Flag signaling that the invited user has chosen to disable their local audio device. The user has muted themselves, but they may choose to unmute their audio feed upon joining the session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_audio_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsAudioEnabled { get; set; } = default!;

        /// <summary>
        /// Flag signaling that the invited user has a video device available for sharing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_video_available", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsVideoAvailable { get; set; } = default!;

        /// <summary>
        /// Flag signaling that the invited user has an audio device available for sharing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_audio_available", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsAudioAvailable { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public static global::G.GuestStarInvite? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GuestStarInvite>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.GuestStarInvite?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.GuestStarInvite?>(serializer.Deserialize<global::G.GuestStarInvite>(jsonReader));
        }

    }
}