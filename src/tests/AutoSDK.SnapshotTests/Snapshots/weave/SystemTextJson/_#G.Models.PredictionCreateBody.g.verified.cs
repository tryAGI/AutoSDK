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
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The inputs to the prediction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Inputs { get; set; }

        /// <summary>
        /// The output of the prediction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Output { get; set; }

        /// <summary>
        /// Optional evaluation run ID to link this prediction as a child call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_run_id")]
        public string? EvaluationRunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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