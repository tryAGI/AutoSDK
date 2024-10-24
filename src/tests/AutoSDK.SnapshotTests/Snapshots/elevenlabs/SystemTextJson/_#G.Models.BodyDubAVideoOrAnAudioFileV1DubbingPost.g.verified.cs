//HintName: G.Models.BodyDubAVideoOrAnAudioFileV1DubbingPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyDubAVideoOrAnAudioFileV1DubbingPost
    {
        /// <summary>
        /// A list of file paths to audio recordings intended for voice cloning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// A list of file paths to audio recordings intended for voice cloning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Name of the dubbing project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// URL of the source video/audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// Source language.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_lang")]
        public string? SourceLang { get; set; }

        /// <summary>
        /// The Target language to dub the content into.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_lang")]
        public string? TargetLang { get; set; }

        /// <summary>
        /// Number of speakers to use for the dubbing. Set to 0 to automatically detect the number of speakers<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_speakers")]
        public int? NumSpeakers { get; set; }

        /// <summary>
        /// Whether to apply watermark to the output video.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermark")]
        public bool? Watermark { get; set; }

        /// <summary>
        /// Start time of the source video/audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public int? StartTime { get; set; }

        /// <summary>
        /// End time of the source video/audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public int? EndTime { get; set; }

        /// <summary>
        /// Whether to use the highest resolution available.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highest_resolution")]
        public bool? HighestResolution { get; set; }

        /// <summary>
        /// An advanced setting. Whether to drop background audio from the final dub. This can improve dub quality where it's known that audio shouldn't have a background track such as for speeches or monologues.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drop_background_audio")]
        public bool? DropBackgroundAudio { get; set; }

        /// <summary>
        /// [BETA] Whether transcripts should have profanities censored with the words '[censored]'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_profanity_filter")]
        public bool? UseProfanityFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.BodyDubAVideoOrAnAudioFileV1DubbingPost? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.BodyDubAVideoOrAnAudioFileV1DubbingPost),
                jsonSerializerContext) as global::G.BodyDubAVideoOrAnAudioFileV1DubbingPost;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.BodyDubAVideoOrAnAudioFileV1DubbingPost? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.BodyDubAVideoOrAnAudioFileV1DubbingPost>(
                json,
                jsonSerializerOptions);
        }

    }
}