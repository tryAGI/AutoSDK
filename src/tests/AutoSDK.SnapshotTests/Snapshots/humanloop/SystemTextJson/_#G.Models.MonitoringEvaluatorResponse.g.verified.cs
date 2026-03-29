//HintName: G.Models.MonitoringEvaluatorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MonitoringEvaluatorResponse
    {
        /// <summary>
        /// ID of the Evaluator used for monitoring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluatorId")]
        public string? EvaluatorId { get; set; }

        /// <summary>
        /// Version ID of the Evaluator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluatorVersionId")]
        public string? EvaluatorVersionId { get; set; }

        /// <summary>
        /// State of the monitoring evaluator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MonitoringEvaluatorResponseStateJsonConverter))]
        public global::G.MonitoringEvaluatorResponseState? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitoringEvaluatorResponse" /> class.
        /// </summary>
        /// <param name="evaluatorId">
        /// ID of the Evaluator used for monitoring.
        /// </param>
        /// <param name="evaluatorVersionId">
        /// Version ID of the Evaluator.
        /// </param>
        /// <param name="state">
        /// State of the monitoring evaluator.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MonitoringEvaluatorResponse(
            string? evaluatorId,
            string? evaluatorVersionId,
            global::G.MonitoringEvaluatorResponseState? state)
        {
            this.EvaluatorId = evaluatorId;
            this.EvaluatorVersionId = evaluatorVersionId;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitoringEvaluatorResponse" /> class.
        /// </summary>
        public MonitoringEvaluatorResponse()
        {
        }
    }
}