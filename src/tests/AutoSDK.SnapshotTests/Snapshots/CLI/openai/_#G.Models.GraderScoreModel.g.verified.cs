//HintName: G.Models.GraderScoreModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ScoreModelGrader object that uses a model to assign a score to the input.
    /// </summary>
    public sealed partial class GraderScoreModel
    {
        /// <summary>
        /// The object type, which is always `score_model`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GraderScoreModelTypeJsonConverter))]
        public global::G.GraderScoreModelType Type { get; set; }

        /// <summary>
        /// The name of the grader.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The model to use for the evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The sampling parameters for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_params")]
        public object? SamplingParams { get; set; }

        /// <summary>
        /// The input text. This may include template strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.EvalItem> Input { get; set; }

        /// <summary>
        /// The range of the score. Defaults to `[0, 1]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        public global::System.Collections.Generic.IList<double>? Range { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraderScoreModel" /> class.
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
        /// <param name="range">
        /// The range of the score. Defaults to `[0, 1]`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraderScoreModel(
            string name,
            string model,
            global::System.Collections.Generic.IList<global::G.EvalItem> input,
            global::G.GraderScoreModelType type,
            object? samplingParams,
            global::System.Collections.Generic.IList<double>? range)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Type = type;
            this.SamplingParams = samplingParams;
            this.Range = range;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraderScoreModel" /> class.
        /// </summary>
        public GraderScoreModel()
        {
        }
    }
}