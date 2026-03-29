//HintName: G.Models.PredictionCreateBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for creating a Prediction via REST API.<br/>
    /// This model excludes project_id since it comes from the URL path in RESTful endpoints.
    /// </summary>
    public sealed partial class PredictionCreateBody
    {
        /// <summary>
        /// The model reference (weave:// URI)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The inputs to the prediction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public object Inputs { get; set; } = default!;

        /// <summary>
        /// The output of the prediction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public object Output { get; set; } = default!;

        /// <summary>
        /// Optional evaluation run ID to link this prediction as a child call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation_run_id")]
        public string? EvaluationRunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionCreateBody" /> class.
        /// </summary>
        /// <param name="model">
        /// The model reference (weave:// URI)
        /// </param>
        /// <param name="inputs">
        /// The inputs to the prediction
        /// </param>
        /// <param name="output">
        /// The output of the prediction
        /// </param>
        /// <param name="evaluationRunId">
        /// Optional evaluation run ID to link this prediction as a child call
        /// </param>
        public PredictionCreateBody(
            string model,
            object inputs,
            object output,
            string? evaluationRunId)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.EvaluationRunId = evaluationRunId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionCreateBody" /> class.
        /// </summary>
        public PredictionCreateBody()
        {
        }
    }
}