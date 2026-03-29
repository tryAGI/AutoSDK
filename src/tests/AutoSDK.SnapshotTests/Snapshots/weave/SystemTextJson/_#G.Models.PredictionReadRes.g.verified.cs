//HintName: G.Models.PredictionReadRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictionReadRes
    {
        /// <summary>
        /// The prediction ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PredictionId { get; set; }

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
        /// Evaluation run ID if this prediction is linked to one
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_run_id")]
        public string? EvaluationRunId { get; set; }

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionReadRes" /> class.
        /// </summary>
        /// <param name="predictionId">
        /// The prediction ID
        /// </param>
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
        /// Evaluation run ID if this prediction is linked to one
        /// </param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PredictionReadRes(
            string predictionId,
            string model,
            object inputs,
            object output,
            string? evaluationRunId,
            string? wbUserId)
        {
            this.PredictionId = predictionId ?? throw new global::System.ArgumentNullException(nameof(predictionId));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.EvaluationRunId = evaluationRunId;
            this.WbUserId = wbUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionReadRes" /> class.
        /// </summary>
        public PredictionReadRes()
        {
        }
    }
}