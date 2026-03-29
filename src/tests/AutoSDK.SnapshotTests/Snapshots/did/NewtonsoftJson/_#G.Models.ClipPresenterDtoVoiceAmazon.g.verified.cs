//HintName: G.Models.ClipPresenterDtoVoiceAmazon.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClipPresenterDtoVoiceAmazon
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ClipPresenterDtoVoiceAmazonType Type { get; set; }

        /// <summary>
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Example: Joanna
        /// </summary>
        /// <example>Joanna</example>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ClipPresenterDtoVoiceAmazonVoiceId VoiceId { get; set; } = default!;

        /// <summary>
        /// Voice customization options. To save the language of the selected agent voice<br/>
        /// Example: English (United States)
        /// </summary>
        /// <example>English (United States)</example>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipPresenterDtoVoiceAmazon" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Example: Joanna
        /// </param>
        /// <param name="type"></param>
        /// <param name="language">
        /// Voice customization options. To save the language of the selected agent voice<br/>
        /// Example: English (United States)
        /// </param>
        public ClipPresenterDtoVoiceAmazon(
            global::G.ClipPresenterDtoVoiceAmazonVoiceId voiceId,
            global::G.ClipPresenterDtoVoiceAmazonType type,
            string? language)
        {
            this.Type = type;
            this.VoiceId = voiceId;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipPresenterDtoVoiceAmazon" /> class.
        /// </summary>
        public ClipPresenterDtoVoiceAmazon()
        {
        }
    }
}