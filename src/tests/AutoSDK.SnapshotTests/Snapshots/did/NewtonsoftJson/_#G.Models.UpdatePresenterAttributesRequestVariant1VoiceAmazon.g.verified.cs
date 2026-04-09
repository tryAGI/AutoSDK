//HintName: G.Models.UpdatePresenterAttributesRequestVariant1VoiceAmazon.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePresenterAttributesRequestVariant1VoiceAmazon
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UpdatePresenterAttributesRequestVariant1VoiceAmazonTypeJsonConverter))]
        public global::G.UpdatePresenterAttributesRequestVariant1VoiceAmazonType Type { get; set; }

        /// <summary>
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Example: Joanna
        /// </summary>
        /// <example>Joanna</example>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UpdatePresenterAttributesRequestVariant1VoiceAmazonVoiceIdJsonConverter))]
        public global::G.UpdatePresenterAttributesRequestVariant1VoiceAmazonVoiceId VoiceId { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="UpdatePresenterAttributesRequestVariant1VoiceAmazon" /> class.
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
        public UpdatePresenterAttributesRequestVariant1VoiceAmazon(
            global::G.UpdatePresenterAttributesRequestVariant1VoiceAmazonVoiceId voiceId,
            global::G.UpdatePresenterAttributesRequestVariant1VoiceAmazonType type,
            string? language)
        {
            this.Type = type;
            this.VoiceId = voiceId;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePresenterAttributesRequestVariant1VoiceAmazon" /> class.
        /// </summary>
        public UpdatePresenterAttributesRequestVariant1VoiceAmazon()
        {
        }
    }
}