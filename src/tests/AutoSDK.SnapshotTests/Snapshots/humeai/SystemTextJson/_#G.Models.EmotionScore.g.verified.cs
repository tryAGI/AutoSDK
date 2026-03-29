//HintName: G.Models.EmotionScore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmotionScore
    {
        /// <summary>
        /// Name of the emotion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Confidence score between 0 and 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmotionScore" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the emotion
        /// </param>
        /// <param name="score">
        /// Confidence score between 0 and 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmotionScore(
            string? name,
            double? score)
        {
            this.Name = name;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmotionScore" /> class.
        /// </summary>
        public EmotionScore()
        {
        }
    }
}