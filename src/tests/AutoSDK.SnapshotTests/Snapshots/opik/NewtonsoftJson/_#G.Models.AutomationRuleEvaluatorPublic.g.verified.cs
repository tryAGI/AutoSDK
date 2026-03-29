//HintName: G.Models.AutomationRuleEvaluatorPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AutomationRuleEvaluatorPublic
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Primary project ID (legacy field for backwards compatibility)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Primary project name (legacy field for backwards compatibility)<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Projects assigned to this rule (unique, sorted alphabetically by name)<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projects")]
        public global::System.Collections.Generic.IList<global::G.ProjectReferencePublic>? Projects { get; set; }

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
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_by")]
        public string? LastUpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action")]
        public global::G.AutomationRuleEvaluatorPublicAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorPublic" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="projectId">
        /// Primary project ID (legacy field for backwards compatibility)
        /// </param>
        /// <param name="projectName">
        /// Primary project name (legacy field for backwards compatibility)<br/>
        /// Included only in responses
        /// </param>
        /// <param name="projects">
        /// Projects assigned to this rule (unique, sorted alphabetically by name)<br/>
        /// Included only in responses
        /// </param>
        /// <param name="samplingRate"></param>
        /// <param name="enabled"></param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedBy">
        /// Included only in responses
        /// </param>
        /// <param name="action"></param>
        public AutomationRuleEvaluatorPublic(
            string name,
            global::System.Guid? id,
            global::System.Guid? projectId,
            string? projectName,
            global::System.Collections.Generic.IList<global::G.ProjectReferencePublic>? projects,
            float? samplingRate,
            bool? enabled,
            global::System.DateTime? createdAt,
            string? createdBy,
            global::System.DateTime? lastUpdatedAt,
            string? lastUpdatedBy,
            global::G.AutomationRuleEvaluatorPublicAction action)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.Projects = projects;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SamplingRate = samplingRate;
            this.Enabled = enabled;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.LastUpdatedAt = lastUpdatedAt;
            this.LastUpdatedBy = lastUpdatedBy;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorPublic" /> class.
        /// </summary>
        public AutomationRuleEvaluatorPublic()
        {
        }
    }
}