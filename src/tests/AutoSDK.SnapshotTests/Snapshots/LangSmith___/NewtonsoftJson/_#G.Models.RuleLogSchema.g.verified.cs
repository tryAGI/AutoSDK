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
        [global::Newtonsoft.Json.JsonProperty("rule_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RuleId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RunId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_name")]
        public string? RunName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_type")]
        public string? RunType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_session_id")]
        public global::System.Guid? RunSessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime EndTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("add_to_annotation_queue")]
        public global::G.RuleLogActionResponse? AddToAnnotationQueue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("add_to_dataset")]
        public global::G.RuleLogActionResponse? AddToDataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluators")]
        public global::G.RuleLogActionResponse? Evaluators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alerts")]
        public global::G.RuleLogActionResponse? Alerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhooks")]
        public global::G.RuleLogActionResponse? Webhooks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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