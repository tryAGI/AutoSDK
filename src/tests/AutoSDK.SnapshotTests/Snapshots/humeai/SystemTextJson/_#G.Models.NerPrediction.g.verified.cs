//HintName: G.Models.NerPrediction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NerPrediction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        public string? Entity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public global::G.PositionInterval? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_confidence")]
        public double? EntityConfidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotions")]
        public global::System.Collections.Generic.IList<global::G.EmotionScore>? Emotions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NerPrediction" /> class.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="position"></param>
        /// <param name="link"></param>
        /// <param name="entityConfidence"></param>
        /// <param name="emotions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NerPrediction(
            string? entity,
            global::G.PositionInterval? position,
            string? link,
            double? entityConfidence,
            global::System.Collections.Generic.IList<global::G.EmotionScore>? emotions)
        {
            this.Entity = entity;
            this.Position = position;
            this.Link = link;
            this.EntityConfidence = entityConfidence;
            this.Emotions = emotions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NerPrediction" /> class.
        /// </summary>
        public NerPrediction()
        {
        }
    }
}