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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The preview talking url of the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// The sentiment of the avatar's expression<br/>
        /// Example: happy
        /// </summary>
        /// <example>happy</example>
        [global::Newtonsoft.Json.JsonProperty("sentiment", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ExpressiveAvatarExpressionDtoVariant1SentimentJsonConverter))]
        public global::G.ExpressiveAvatarExpressionDtoVariant1Sentiment Sentiment { get; set; } = default!;

        /// <summary>
        /// The description of the avatar's expression<br/>
        /// Example: An enthusiastic, expressive avatar full of charm and personality.”
        /// </summary>
        /// <example>An enthusiastic, expressive avatar full of charm and personality.”</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The voice of the expression
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.AnyOf<global::G.ExpressiveAvatarExpressionDtoVariant1VoiceMicrosoft, global::G.ExpressiveAvatarExpressionDtoVariant1VoiceElevenLabs, global::G.ExpressiveAvatarExpressionDtoVariant1VoiceAmazon, global::G.ExpressiveAvatarExpressionDtoVariant1VoiceGoogle, global::G.ExpressiveAvatarExpressionDtoVariant1VoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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