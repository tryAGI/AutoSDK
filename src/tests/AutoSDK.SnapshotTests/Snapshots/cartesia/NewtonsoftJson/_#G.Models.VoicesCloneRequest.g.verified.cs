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
        [global::Newtonsoft.Json.JsonProperty("clip")]
        public byte[]? Clip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clipname")]
        public string? Clipname { get; set; }

        /// <summary>
        /// The name of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description for the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SupportedLanguageJsonConverter))]
        public global::G.SupportedLanguage? Language { get; set; }

        /// <summary>
        /// The ID of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_voice_id")]
        public string? BaseVoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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