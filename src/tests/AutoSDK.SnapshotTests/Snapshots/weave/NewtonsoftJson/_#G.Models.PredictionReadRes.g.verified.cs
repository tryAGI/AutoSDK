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
        [global::Newtonsoft.Json.JsonProperty("prediction_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PredictionId { get; set; } = default!;

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
        /// Evaluation run ID if this prediction is linked to one
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation_run_id")]
        public string? EvaluationRunId { get; set; }

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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