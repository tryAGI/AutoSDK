//HintName: G.Models.ExpressiveAvatarExpressionDtoVariant1VoiceAmazon.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExpressiveAvatarExpressionDtoVariant1VoiceAmazon
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonType Type { get; set; }

        /// <summary>
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Example: Joanna
        /// </summary>
        /// <example>Joanna</example>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId VoiceId { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ExpressiveAvatarExpressionDtoVariant1VoiceAmazon" /> class.
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
        public ExpressiveAvatarExpressionDtoVariant1VoiceAmazon(
            global::G.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId voiceId,
            global::G.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonType type,
            string? language)
        {
            this.Type = type;
            this.VoiceId = voiceId;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressiveAvatarExpressionDtoVariant1VoiceAmazon" /> class.
        /// </summary>
        public ExpressiveAvatarExpressionDtoVariant1VoiceAmazon()
        {
        }
    }
}