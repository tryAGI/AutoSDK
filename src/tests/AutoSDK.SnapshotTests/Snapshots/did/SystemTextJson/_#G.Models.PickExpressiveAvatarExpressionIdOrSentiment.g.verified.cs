//HintName: G.Models.PickExpressiveAvatarExpressionIdOrSentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickExpressiveAvatarExpressionIdOrSentiment
    {
        /// <summary>
        /// The id of the expression
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The sentiment of the avatar's expression<br/>
        /// Example: happy
        /// </summary>
        /// <example>happy</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PickExpressiveAvatarExpressionIdOrSentimentSentimentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PickExpressiveAvatarExpressionIdOrSentimentSentiment Sentiment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickExpressiveAvatarExpressionIdOrSentiment" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the expression
        /// </param>
        /// <param name="sentiment">
        /// The sentiment of the avatar's expression<br/>
        /// Example: happy
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PickExpressiveAvatarExpressionIdOrSentiment(
            string id,
            global::G.PickExpressiveAvatarExpressionIdOrSentimentSentiment sentiment)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Sentiment = sentiment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickExpressiveAvatarExpressionIdOrSentiment" /> class.
        /// </summary>
        public PickExpressiveAvatarExpressionIdOrSentiment()
        {
        }
    }
}