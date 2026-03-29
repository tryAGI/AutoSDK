//HintName: G.Models.VoicesCloneRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicesCloneRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clip")]
        public byte[]? Clip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clipname")]
        public string? Clipname { get; set; }

        /// <summary>
        /// The name of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description for the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SupportedLanguageJsonConverter))]
        public global::G.SupportedLanguage? Language { get; set; }

        /// <summary>
        /// The ID of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_voice_id")]
        public string? BaseVoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesCloneRequest" /> class.
        /// </summary>
        /// <param name="clip"></param>
        /// <param name="clipname"></param>
        /// <param name="name">
        /// The name of the voice.
        /// </param>
        /// <param name="description">
        /// A description for the voice.
        /// </param>
        /// <param name="language">
        /// The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).
        /// </param>
        /// <param name="baseVoiceId">
        /// The ID of the voice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoicesCloneRequest(
            byte[]? clip,
            string? clipname,
            string? name,
            string? description,
            global::G.SupportedLanguage? language,
            string? baseVoiceId)
        {
            this.Clip = clip;
            this.Clipname = clipname;
            this.Name = name;
            this.Description = description;
            this.Language = language;
            this.BaseVoiceId = baseVoiceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesCloneRequest" /> class.
        /// </summary>
        public VoicesCloneRequest()
        {
        }
    }
}