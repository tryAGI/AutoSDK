//HintName: G.Models.CohortAggregatedResultTopQuestion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CohortAggregatedResultTopQuestion
    {
        /// <summary>
        /// ID of the question cluster
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("question_cluster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QuestionClusterId { get; set; }

        /// <summary>
        /// Text of the question
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Number of resolved occurrences
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Resolved { get; set; }

        /// <summary>
        /// Total count of occurrences
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortAggregatedResultTopQuestion" /> class.
        /// </summary>
        /// <param name="questionClusterId">
        /// ID of the question cluster
        /// </param>
        /// <param name="text">
        /// Text of the question
        /// </param>
        /// <param name="resolved">
        /// Number of resolved occurrences
        /// </param>
        /// <param name="count">
        /// Total count of occurrences
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CohortAggregatedResultTopQuestion(
            string questionClusterId,
            string text,
            double resolved,
            double count)
        {
            this.QuestionClusterId = questionClusterId ?? throw new global::System.ArgumentNullException(nameof(questionClusterId));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Resolved = resolved;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortAggregatedResultTopQuestion" /> class.
        /// </summary>
        public CohortAggregatedResultTopQuestion()
        {
        }
    }
}