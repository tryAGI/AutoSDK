//HintName: G.Models.ExpressiveAvatarExpressionDtoVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class ExpressiveAvatarExpressionDtoVariant1
    {
        /// <summary>
        /// The id of the expression
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The preview talking url of the avatar
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// The sentiment of the avatar's expression<br/>
        /// Example: happy
        /// </summary>
        /// <example>happy</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExpressiveAvatarExpressionDtoVariant1SentimentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExpressiveAvatarExpressionDtoVariant1Sentiment Sentiment { get; set; }

        /// <summary>
        /// The description of the avatar's expression<br/>
        /// Example: An enthusiastic, expressive avatar full of charm and personality.”
        /// </summary>
        /// <example>An enthusiastic, expressive avatar full of charm and personality.”</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The voice of the expression
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.ExpressiveAvatarExpressionDtoVariant1VoiceMicrosoft, global::G.ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabs, global::G.ExpressiveAvatarExpressionDtoVariant1VoiceAmazon, global::G.ExpressiveAvatarExpressionDtoVariant1VoiceGoogle, global::G.ExpressiveAvatarExpressionDtoVariant1VoiceOpenAI>))]
        public global::G.AnyOf<global::G.ExpressiveAvatarExpressionDtoVariant1VoiceMicrosoft, global::G.ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabs, global::G.ExpressiveAvatarExpressionDtoVariant1VoiceAmazon, global::G.ExpressiveAvatarExpressionDtoVariant1VoiceGoogle, global::G.ExpressiveAvatarExpressionDtoVariant1VoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressiveAvatarExpressionDtoVariant1" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the expression
        /// </param>
        /// <param name="sentiment">
        /// The sentiment of the avatar's expression<br/>
        /// Example: happy
        /// </param>
        /// <param name="description">
        /// The description of the avatar's expression<br/>
        /// Example: An enthusiastic, expressive avatar full of charm and personality.”
        /// </param>
        /// <param name="previewUrl">
        /// The preview talking url of the avatar
        /// </param>
        /// <param name="voice">
        /// The voice of the expression
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExpressiveAvatarExpressionDtoVariant1(
            string id,
            global::G.ExpressiveAvatarExpressionDtoVariant1Sentiment sentiment,
            string description,
            string? previewUrl,
            global::G.AnyOf<global::G.ExpressiveAvatarExpressionDtoVariant1VoiceMicrosoft, global::G.ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabs, global::G.ExpressiveAvatarExpressionDtoVariant1VoiceAmazon, global::G.ExpressiveAvatarExpressionDtoVariant1VoiceGoogle, global::G.ExpressiveAvatarExpressionDtoVariant1VoiceOpenAI>? voice)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PreviewUrl = previewUrl;
            this.Sentiment = sentiment;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressiveAvatarExpressionDtoVariant1" /> class.
        /// </summary>
        public ExpressiveAvatarExpressionDtoVariant1()
        {
        }
    }
}