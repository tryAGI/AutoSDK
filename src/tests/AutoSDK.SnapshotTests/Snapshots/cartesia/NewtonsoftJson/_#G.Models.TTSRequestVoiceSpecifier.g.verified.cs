//HintName: G.Models.TTSRequestVoiceSpecifier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TTSRequestVoiceSpecifier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TTSRequestVoiceSpecifierModeJsonConverter))]
        public global::G.TTSRequestVoiceSpecifierMode Mode { get; set; }

        /// <summary>
        /// The ID of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSRequestVoiceSpecifier" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the voice.
        /// </param>
        /// <param name="mode"></param>
        public TTSRequestVoiceSpecifier(
            string id,
            global::G.TTSRequestVoiceSpecifierMode mode)
        {
            this.Mode = mode;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSRequestVoiceSpecifier" /> class.
        /// </summary>
        public TTSRequestVoiceSpecifier()
        {
        }
    }
}