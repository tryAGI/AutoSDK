//HintName: G.Models.AutomationRuleEvaluatorUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AutomationRuleEvaluatorUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sampling_rate")]
        public float? SamplingRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Primary project ID (legacy field, maintained for backwards compatibility)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Multiple project IDs (new field for multi-project support)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ProjectIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AutomationRuleEvaluatorUpdateActionJsonConverter))]
        public global::G.AutomationRuleEvaluatorUpdateAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="samplingRate"></param>
        /// <param name="enabled"></param>
        /// <param name="projectId">
        /// Primary project ID (legacy field, maintained for backwards compatibility)
        /// </param>
        /// <param name="projectIds">
        /// Multiple project IDs (new field for multi-project support)
        /// </param>
        /// <param name="action"></param>
        public AutomationRuleEvaluatorUpdate(
            string name,
            float? samplingRate,
            bool? enabled,
            global::System.Guid? projectId,
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds,
            global::G.AutomationRuleEvaluatorUpdateAction action)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SamplingRate = samplingRate;
            this.Enabled = enabled;
            this.ProjectId = projectId;
            this.ProjectIds = projectIds;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorUpdate" /> class.
        /// </summary>
        public AutomationRuleEvaluatorUpdate()
        {
        }
    }
}