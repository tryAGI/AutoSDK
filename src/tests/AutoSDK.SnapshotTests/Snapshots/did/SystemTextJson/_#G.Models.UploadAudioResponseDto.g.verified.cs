//HintName: G.Models.UploadAudioResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadAudioResponseDto
    {
        /// <summary>
        /// The temporary URL of the audio.<br/>
        /// This URL should be provided when creating an animation via the /animations endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// A unique identifier for the audio.<br/>
        /// This identifier should be used when deleting the audio via the /audio/{id} endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The duration of the audio in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// The audio moderation results metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation_metadata")]
        public global::G.UploadAudioResponseDtoModerationMetadata? ModerationMetadata { get; set; }

        /// <summary>
        /// The URL of the word level timestamps file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordLevelTimestampsUrl")]
        public string? WordLevelTimestampsUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAudioResponseDto" /> class.
        /// </summary>
        /// <param name="url">
        /// The temporary URL of the audio.<br/>
        /// This URL should be provided when creating an animation via the /animations endpoint.
        /// </param>
        /// <param name="id">
        /// A unique identifier for the audio.<br/>
        /// This identifier should be used when deleting the audio via the /audio/{id} endpoint.
        /// </param>
        /// <param name="duration">
        /// The duration of the audio in seconds
        /// </param>
        /// <param name="moderationMetadata">
        /// The audio moderation results metadata.
        /// </param>
        /// <param name="wordLevelTimestampsUrl">
        /// The URL of the word level timestamps file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadAudioResponseDto(
            string url,
            string? id,
            double? duration,
            global::G.UploadAudioResponseDtoModerationMetadata? moderationMetadata,
            string? wordLevelTimestampsUrl)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Id = id;
            this.Duration = duration;
            this.ModerationMetadata = moderationMetadata;
            this.WordLevelTimestampsUrl = wordLevelTimestampsUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAudioResponseDto" /> class.
        /// </summary>
        public UploadAudioResponseDto()
        {
        }
    }
}