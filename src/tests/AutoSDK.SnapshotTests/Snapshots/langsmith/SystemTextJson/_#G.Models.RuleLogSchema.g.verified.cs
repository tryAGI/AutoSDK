//HintName: G.Models.RuleLogSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Run rules log schema.
    /// </summary>
    public sealed partial class RuleLogSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RuleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_name")]
        public string? RunName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_type")]
        public string? RunType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_session_id")]
        public global::System.Guid? RunSessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_to_annotation_queue")]
        public global::G.RuleLogActionResponse? AddToAnnotationQueue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_to_dataset")]
        public global::G.RuleLogActionResponse? AddToDataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluators")]
        public global::G.RuleLogActionResponse? Evaluators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alerts")]
        public global::G.RuleLogActionResponse? Alerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhooks")]
        public global::G.RuleLogActionResponse? Webhooks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleLogSchema" /> class.
        /// </summary>
        /// <param name="ruleId"></param>
        /// <param name="runId"></param>
        /// <param name="runName"></param>
        /// <param name="runType"></param>
        /// <param name="runSessionId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="addToAnnotationQueue"></param>
        /// <param name="addToDataset"></param>
        /// <param name="evaluators"></param>
        /// <param name="alerts"></param>
        /// <param name="webhooks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RuleLogSchema(
            global::System.Guid ruleId,
            global::System.Guid runId,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            string? runName,
            string? runType,
            global::System.Guid? runSessionId,
            global::G.RuleLogActionResponse? addToAnnotationQueue,
            global::G.RuleLogActionResponse? addToDataset,
            global::G.RuleLogActionResponse? evaluators,
            global::G.RuleLogActionResponse? alerts,
            global::G.RuleLogActionResponse? webhooks)
        {
            this.RuleId = ruleId;
            this.RunId = runId;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.RunName = runName;
            this.RunType = runType;
            this.RunSessionId = runSessionId;
            this.AddToAnnotationQueue = addToAnnotationQueue;
            this.AddToDataset = addToDataset;
            this.Evaluators = evaluators;
            this.Alerts = alerts;
            this.Webhooks = webhooks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleLogSchema" /> class.
        /// </summary>
        public RuleLogSchema()
        {
        }
    }
}