//HintName: G.Models.EvaluationCreateBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationCreateBody
    {
        /// <summary>
        /// The name of this evaluation.  Evaluations with the same name will be versioned together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of this evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Reference to the dataset (weave:// URI)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dataset { get; set; }

        /// <summary>
        /// List of scorer references (weave:// URIs)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorers")]
        public global::System.Collections.Generic.IList<string>? Scorers { get; set; }

        /// <summary>
        /// Number of trials to run<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trials")]
        public int? Trials { get; set; }

        /// <summary>
        /// Name for the evaluation run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_name")]
        public string? EvaluationName { get; set; }

        /// <summary>
        /// Optional attributes for the evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_attributes")]
        public object? EvalAttributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationCreateBody" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of this evaluation.  Evaluations with the same name will be versioned together.
        /// </param>
        /// <param name="dataset">
        /// Reference to the dataset (weave:// URI)
        /// </param>
        /// <param name="description">
        /// A description of this evaluation
        /// </param>
        /// <param name="scorers">
        /// List of scorer references (weave:// URIs)
        /// </param>
        /// <param name="trials">
        /// Number of trials to run<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="evaluationName">
        /// Name for the evaluation run
        /// </param>
        /// <param name="evalAttributes">
        /// Optional attributes for the evaluation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationCreateBody(
            string name,
            string dataset,
            string? description,
            global::System.Collections.Generic.IList<string>? scorers,
            int? trials,
            string? evaluationName,
            object? evalAttributes)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Dataset = dataset ?? throw new global::System.ArgumentNullException(nameof(dataset));
            this.Scorers = scorers;
            this.Trials = trials;
            this.EvaluationName = evaluationName;
            this.EvalAttributes = evalAttributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationCreateBody" /> class.
        /// </summary>
        public EvaluationCreateBody()
        {
        }
    }
}