//HintName: G.Models.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazon.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazon
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonTypeJsonConverter))]
        public global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonType Type { get; set; }

        /// <summary>
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Example: Joanna
        /// </summary>
        /// <example>Joanna</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonVoiceIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonVoiceId VoiceId { get; set; }

        /// <summary>
        /// Voice customization options. To save the language of the selected agent voice<br/>
        /// Example: English (United States)
        /// </summary>
        /// <example>English (United States)</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazon" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazon(
            global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonVoiceId voiceId,
            global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonType type,
            string? language)
        {
            this.Type = type;
            this.VoiceId = voiceId;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazon" /> class.
        /// </summary>
        public GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazon()
        {
        }
    }
}