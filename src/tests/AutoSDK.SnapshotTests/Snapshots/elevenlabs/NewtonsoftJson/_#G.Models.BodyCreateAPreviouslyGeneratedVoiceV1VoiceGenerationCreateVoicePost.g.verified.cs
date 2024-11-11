//HintName: G.Models.BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost
    {
        /// <summary>
        /// Name to use for the created voice.<br/>
        /// Example: Little squeaky mouse
        /// </summary>
        /// <example>Little squeaky mouse</example>
        [global::Newtonsoft.Json.JsonProperty("voice_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceName { get; set; } = default!;

        /// <summary>
        /// Description to use for the created voice.<br/>
        /// Example: A sassy little squeaky mouse
        /// </summary>
        /// <example>A sassy little squeaky mouse</example>
        [global::Newtonsoft.Json.JsonProperty("voice_description", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceDescription { get; set; } = default!;

        /// <summary>
        /// The generated_voice_id to create, call POST /v1/voice-generation/generate-voice and fetch the generated_voice_id from the response header if don't have one yet.<br/>
        /// Example: 37HceQefKmEi3bGovXjL
        /// </summary>
        /// <example>37HceQefKmEi3bGovXjL</example>
        [global::Newtonsoft.Json.JsonProperty("generated_voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string GeneratedVoiceId { get; set; } = default!;

        /// <summary>
        /// List of voice ids that the user has played but not selected. Used for RLHF.<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("played_not_selected_voice_ids")]
        public global::System.Collections.Generic.IList<string>? PlayedNotSelectedVoiceIds { get; set; }

        /// <summary>
        /// Optional, metadata to add to the created voice. Defaults to None.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost" /> class.
        /// </summary>
        /// <param name="voiceName">
        /// Name to use for the created voice.<br/>
        /// Example: Little squeaky mouse
        /// </param>
        /// <param name="voiceDescription">
        /// Description to use for the created voice.<br/>
        /// Example: A sassy little squeaky mouse
        /// </param>
        /// <param name="generatedVoiceId">
        /// The generated_voice_id to create, call POST /v1/voice-generation/generate-voice and fetch the generated_voice_id from the response header if don't have one yet.<br/>
        /// Example: 37HceQefKmEi3bGovXjL
        /// </param>
        /// <param name="playedNotSelectedVoiceIds">
        /// List of voice ids that the user has played but not selected. Used for RLHF.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="labels">
        /// Optional, metadata to add to the created voice. Defaults to None.
        /// </param>
        public BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost(
            string voiceName,
            string voiceDescription,
            string generatedVoiceId,
            global::System.Collections.Generic.IList<string>? playedNotSelectedVoiceIds,
            global::System.Collections.Generic.Dictionary<string, string>? labels)
        {
            this.VoiceName = voiceName ?? throw new global::System.ArgumentNullException(nameof(voiceName));
            this.VoiceDescription = voiceDescription ?? throw new global::System.ArgumentNullException(nameof(voiceDescription));
            this.GeneratedVoiceId = generatedVoiceId ?? throw new global::System.ArgumentNullException(nameof(generatedVoiceId));
            this.PlayedNotSelectedVoiceIds = playedNotSelectedVoiceIds;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost" /> class.
        /// </summary>
        public BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost()
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
        public static global::G.BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost?>(serializer.Deserialize<global::G.BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost>(jsonReader));
        }

    }
}