//HintName: G.Models.CreateAvatarRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAvatarRequest
    {
        /// <summary>
        /// Avatar image as Base64 string or URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// Audio ID for lip-sync. Either audio_id or sound_file is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_id")]
        public string? AudioId { get; set; }

        /// <summary>
        /// Audio file as Base64 string or URL. Formats mp3, wav, m4a, aac. Max 5MB, 2-300 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sound_file")]
        public string? SoundFile { get; set; }

        /// <summary>
        /// Text prompt for avatar generation. Max 2500 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Generation mode.<br/>
        /// Default Value: std
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateAvatarRequestModeJsonConverter))]
        public global::G.CreateAvatarRequestMode? Mode { get; set; }

        /// <summary>
        /// URL to receive webhook callback when task completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// Avatar image as Base64 string or URL.
        /// </param>
        /// <param name="audioId">
        /// Audio ID for lip-sync. Either audio_id or sound_file is required.
        /// </param>
        /// <param name="soundFile">
        /// Audio file as Base64 string or URL. Formats mp3, wav, m4a, aac. Max 5MB, 2-300 seconds.
        /// </param>
        /// <param name="prompt">
        /// Text prompt for avatar generation. Max 2500 characters.
        /// </param>
        /// <param name="mode">
        /// Generation mode.<br/>
        /// Default Value: std
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAvatarRequest(
            string image,
            string? audioId,
            string? soundFile,
            string? prompt,
            global::G.CreateAvatarRequestMode? mode,
            string? callbackUrl)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.AudioId = audioId;
            this.SoundFile = soundFile;
            this.Prompt = prompt;
            this.Mode = mode;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarRequest" /> class.
        /// </summary>
        public CreateAvatarRequest()
        {
        }
    }
}