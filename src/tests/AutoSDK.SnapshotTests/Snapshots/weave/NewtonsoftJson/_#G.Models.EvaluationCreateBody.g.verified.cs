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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A description of this evaluation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Reference to the dataset (weave:// URI)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset", Required = global::Newtonsoft.Json.Required.Always)]
        public string Dataset { get; set; } = default!;

        /// <summary>
        /// List of scorer references (weave:// URIs)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scorers")]
        public global::System.Collections.Generic.IList<string>? Scorers { get; set; }

        /// <summary>
        /// Number of trials to run<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trials")]
        public int? Trials { get; set; }

        /// <summary>
        /// Name for the evaluation run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation_name")]
        public string? EvaluationName { get; set; }

        /// <summary>
        /// Optional attributes for the evaluation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eval_attributes")]
        public object? EvalAttributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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