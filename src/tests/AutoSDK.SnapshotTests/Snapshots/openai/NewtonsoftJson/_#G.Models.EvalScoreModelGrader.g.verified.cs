//HintName: G.Models.EvalScoreModelGrader.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ScoreModelGrader object that uses a model to assign a score to the input.
    /// </summary>
    public sealed partial class EvalScoreModelGrader
    {
        /// <summary>
        /// The object type, which is always `score_model`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.EvalScoreModelGraderType Type { get; set; }

        /// <summary>
        /// The name of the grader.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The model to use for the evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The sampling parameters for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sampling_params")]
        public object? SamplingParams { get; set; }

        /// <summary>
        /// The input text. This may include template strings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EvalItem> Input { get; set; } = default!;

        /// <summary>
        /// The threshold for the score.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pass_threshold")]
        public double? PassThreshold { get; set; }

        /// <summary>
        /// The range of the score. Defaults to `[0, 1]`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("range")]
        public global::System.Collections.Generic.IList<double>? Range { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalScoreModelGrader" /> class.
        /// </summary>
        /// <param name="type">
        /// The object type, which is always `score_model`.
        /// </param>
        /// <param name="name">
        /// The name of the grader.
        /// </param>
        /// <param name="model">
        /// The model to use for the evaluation.
        /// </param>
        /// <param name="samplingParams">
        /// The sampling parameters for the model.
        /// </param>
        /// <param name="input">
        /// The input text. This may include template strings.
        /// </param>
        /// <param name="passThreshold">
        /// The threshold for the score.
        /// </param>
        /// <param name="range">
        /// The range of the score. Defaults to `[0, 1]`.
        /// </param>
        public EvalScoreModelGrader(
            string name,
            string model,
            global::System.Collections.Generic.IList<global::G.EvalItem> input,
            global::G.EvalScoreModelGraderType type,
            object? samplingParams,
            double? passThreshold,
            global::System.Collections.Generic.IList<double>? range)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Type = type;
            this.SamplingParams = samplingParams;
            this.PassThreshold = passThreshold;
            this.Range = range;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalScoreModelGrader" /> class.
        /// </summary>
        public EvalScoreModelGrader()
        {
        }
    }
}