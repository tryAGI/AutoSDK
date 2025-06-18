//HintName: G.Models.GraderTextSimilarity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A TextSimilarityGrader object which grades text based on similarity metrics.
    /// </summary>
    public sealed partial class GraderTextSimilarity
    {
        /// <summary>
        /// The type of grader.<br/>
        /// Default Value: text_similarity
        /// </summary>
        /// <default>global::G.GraderTextSimilarityType.TextSimilarity</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GraderTextSimilarityTypeJsonConverter))]
        public global::G.GraderTextSimilarityType Type { get; set; } = global::G.GraderTextSimilarityType.TextSimilarity;

        /// <summary>
        /// The name of the grader.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The text being graded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// The text being graded against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reference { get; set; }

        /// <summary>
        /// The evaluation metric to use. One of `fuzzy_match`, `bleu`, `gleu`, `meteor`, `rouge_1`, `rouge_2`, `rouge_3`, `rouge_4`, `rouge_5`, or `rouge_l`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GraderTextSimilarityEvaluationMetricJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GraderTextSimilarityEvaluationMetric EvaluationMetric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraderTextSimilarity" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of grader.<br/>
        /// Default Value: text_similarity
        /// </param>
        /// <param name="name">
        /// The name of the grader.
        /// </param>
        /// <param name="input">
        /// The text being graded.
        /// </param>
        /// <param name="reference">
        /// The text being graded against.
        /// </param>
        /// <param name="evaluationMetric">
        /// The evaluation metric to use. One of `fuzzy_match`, `bleu`, `gleu`, `meteor`, `rouge_1`, `rouge_2`, `rouge_3`, `rouge_4`, `rouge_5`, or `rouge_l`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraderTextSimilarity(
            string name,
            string input,
            string reference,
            global::G.GraderTextSimilarityEvaluationMetric evaluationMetric,
            global::G.GraderTextSimilarityType type = global::G.GraderTextSimilarityType.TextSimilarity)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Reference = reference ?? throw new global::System.ArgumentNullException(nameof(reference));
            this.EvaluationMetric = evaluationMetric;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraderTextSimilarity" /> class.
        /// </summary>
        public GraderTextSimilarity()
        {
        }
    }
}