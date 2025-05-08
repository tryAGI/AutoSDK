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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.EvalTextSimilarityGraderType Type { get; set; } = global::G.EvalTextSimilarityGraderType.TextSimilarity;

        /// <summary>
        /// The name of the grader.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The text being graded.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public string Input { get; set; } = default!;

        /// <summary>
        /// The text being graded against.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference", Required = global::Newtonsoft.Json.Required.Always)]
        public string Reference { get; set; } = default!;

        /// <summary>
        /// A float score where a value greater than or equal indicates a passing grade.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pass_threshold", Required = global::Newtonsoft.Json.Required.Always)]
        public double PassThreshold { get; set; } = default!;

        /// <summary>
        /// The evaluation metric to use. One of `fuzzy_match`, `bleu`, `gleu`, `meteor`, `rouge_1`, `rouge_2`, `rouge_3`, `rouge_4`, `rouge_5`, or `rouge_l`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation_metric", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EvalTextSimilarityGraderEvaluationMetric EvaluationMetric { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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