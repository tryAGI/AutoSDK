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
        [global::Newtonsoft.Json.JsonProperty("question_cluster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string QuestionClusterId { get; set; } = default!;

        /// <summary>
        /// Text of the question
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Number of resolved occurrences
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resolved", Required = global::Newtonsoft.Json.Required.Always)]
        public double Resolved { get; set; } = default!;

        /// <summary>
        /// Total count of occurrences
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public double Count { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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