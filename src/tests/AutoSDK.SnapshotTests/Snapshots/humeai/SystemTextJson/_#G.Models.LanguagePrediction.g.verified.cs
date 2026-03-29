//HintName: G.Models.LanguagePrediction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguagePrediction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public global::G.PositionInterval? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotions")]
        public global::System.Collections.Generic.IList<global::G.EmotionScore>? Emotions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        public global::System.Collections.Generic.IList<global::G.SentimentScore>? Sentiment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toxicity")]
        public global::System.Collections.Generic.IList<global::G.ToxicityScore>? Toxicity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePrediction" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="position"></param>
        /// <param name="emotions"></param>
        /// <param name="sentiment"></param>
        /// <param name="toxicity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LanguagePrediction(
            string? text,
            global::G.PositionInterval? position,
            global::System.Collections.Generic.IList<global::G.EmotionScore>? emotions,
            global::System.Collections.Generic.IList<global::G.SentimentScore>? sentiment,
            global::System.Collections.Generic.IList<global::G.ToxicityScore>? toxicity)
        {
            this.Text = text;
            this.Position = position;
            this.Emotions = emotions;
            this.Sentiment = sentiment;
            this.Toxicity = toxicity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePrediction" /> class.
        /// </summary>
        public LanguagePrediction()
        {
        }
    }
}