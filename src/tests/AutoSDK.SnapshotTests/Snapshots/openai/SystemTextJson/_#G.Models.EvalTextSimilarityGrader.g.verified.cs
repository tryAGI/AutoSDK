//HintName: G.Models.EvalTextSimilarityGrader.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A TextSimilarityGrader object which grades text based on similarity metrics.
    /// </summary>
    public sealed partial class EvalTextSimilarityGrader
    {
        /// <summary>
        /// The type of grader.<br/>
        /// Default Value: text_similarity
        /// </summary>
        /// <default>global::G.EvalTextSimilarityGraderType.TextSimilarity</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalTextSimilarityGraderTypeJsonConverter))]
        public global::G.EvalTextSimilarityGraderType Type { get; set; } = global::G.EvalTextSimilarityGraderType.TextSimilarity;

        /// <summary>
        /// The name of the grader.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        /// A float score where a value greater than or equal indicates a passing grade.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PassThreshold { get; set; }

        /// <summary>
        /// The evaluation metric to use. One of `fuzzy_match`, `bleu`, `gleu`, `meteor`, `rouge_1`, `rouge_2`, `rouge_3`, `rouge_4`, `rouge_5`, or `rouge_l`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalTextSimilarityGraderEvaluationMetricJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EvalTextSimilarityGraderEvaluationMetric EvaluationMetric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalTextSimilarityGrader" /> class.
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
        /// <param name="passThreshold">
        /// A float score where a value greater than or equal indicates a passing grade.
        /// </param>
        /// <param name="evaluationMetric">
        /// The evaluation metric to use. One of `fuzzy_match`, `bleu`, `gleu`, `meteor`, `rouge_1`, `rouge_2`, `rouge_3`, `rouge_4`, `rouge_5`, or `rouge_l`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalTextSimilarityGrader(
            string input,
            string reference,
            double passThreshold,
            global::G.EvalTextSimilarityGraderEvaluationMetric evaluationMetric,
            string? name,
            global::G.EvalTextSimilarityGraderType type = global::G.EvalTextSimilarityGraderType.TextSimilarity)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Reference = reference ?? throw new global::System.ArgumentNullException(nameof(reference));
            this.PassThreshold = passThreshold;
            this.EvaluationMetric = evaluationMetric;
            this.Type = type;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalTextSimilarityGrader" /> class.
        /// </summary>
        public EvalTextSimilarityGrader()
        {
        }
    }
}