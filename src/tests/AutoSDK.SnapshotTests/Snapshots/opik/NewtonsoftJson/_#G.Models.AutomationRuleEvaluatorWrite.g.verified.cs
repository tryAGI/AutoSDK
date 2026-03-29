//HintName: G.Models.AutomationRuleEvaluatorWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AutomationRuleEvaluatorWrite
    {
        /// <summary>
        /// Primary project ID (legacy field for backwards compatibility)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Project IDs for write operations (used when creating/updating rules)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ProjectIds { get; set; }

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action")]
        public global::G.AutomationRuleEvaluatorWriteAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorWrite" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projectId">
        /// Primary project ID (legacy field for backwards compatibility)
        /// </param>
        /// <param name="projectIds">
        /// Project IDs for write operations (used when creating/updating rules)
        /// </param>
        /// <param name="samplingRate"></param>
        /// <param name="enabled"></param>
        /// <param name="action"></param>
        public AutomationRuleEvaluatorWrite(
            string name,
            global::System.Guid? projectId,
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds,
            float? samplingRate,
            bool? enabled,
            global::G.AutomationRuleEvaluatorWriteAction action)
        {
            this.ProjectId = projectId;
            this.ProjectIds = projectIds;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SamplingRate = samplingRate;
            this.Enabled = enabled;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorWrite" /> class.
        /// </summary>
        public AutomationRuleEvaluatorWrite()
        {
        }
    }
}