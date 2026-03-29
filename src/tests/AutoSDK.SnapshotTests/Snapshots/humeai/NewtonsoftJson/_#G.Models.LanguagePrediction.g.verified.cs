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
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position")]
        public global::G.PositionInterval? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emotions")]
        public global::System.Collections.Generic.IList<global::G.EmotionScore>? Emotions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentiment")]
        public global::System.Collections.Generic.IList<global::G.SentimentScore>? Sentiment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toxicity")]
        public global::System.Collections.Generic.IList<global::G.ToxicityScore>? Toxicity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePrediction" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="position"></param>
        /// <param name="emotions"></param>
        /// <param name="sentiment"></param>
        /// <param name="toxicity"></param>
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