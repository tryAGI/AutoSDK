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
        [global::Newtonsoft.Json.JsonProperty("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// A list of file paths to audio recordings intended for voice cloning
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Name of the dubbing project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// URL of the source video/audio file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// Source language.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_lang")]
        public string? SourceLang { get; set; } = "auto";

        /// <summary>
        /// The Target language to dub the content into.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_lang")]
        public string? TargetLang { get; set; }

        /// <summary>
        /// Number of speakers to use for the dubbing. Set to 0 to automatically detect the number of speakers<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_speakers")]
        public int? NumSpeakers { get; set; } = 0;

        /// <summary>
        /// Whether to apply watermark to the output video.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("watermark")]
        public bool? Watermark { get; set; } = false;

        /// <summary>
        /// Start time of the source video/audio file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public int? StartTime { get; set; }

        /// <summary>
        /// End time of the source video/audio file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public int? EndTime { get; set; }

        /// <summary>
        /// Whether to use the highest resolution available.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("highest_resolution")]
        public bool? HighestResolution { get; set; } = false;

        /// <summary>
        /// An advanced setting. Whether to drop background audio from the final dub. This can improve dub quality where it's known that audio shouldn't have a background track such as for speeches or monologues.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("drop_background_audio")]
        public bool? DropBackgroundAudio { get; set; } = false;

        /// <summary>
        /// [BETA] Whether transcripts should have profanities censored with the words '[censored]'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_profanity_filter")]
        public bool? UseProfanityFilter { get; set; }

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
        public static global::G.BodyDubAVideoOrAnAudioFileV1DubbingPost? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BodyDubAVideoOrAnAudioFileV1DubbingPost>(
                json,
                jsonSerializerOptions);
        }

    }
}