//HintName: G.Models.AutomationRuleEvaluatorObjectObjectPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPolymorphic(
        TypeDiscriminatorPropertyName = "type",
        IgnoreUnrecognizedTypeDiscriminators = true,
        UnknownDerivedTypeHandling = global::System.Text.Json.Serialization.JsonUnknownDerivedTypeHandling.FallBackToBaseType)]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.AutomationRuleEvaluatorLlmAsJudgePublic), typeDiscriminator: "llm_as_judge")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.AutomationRuleEvaluatorSpanLlmAsJudgePublic), typeDiscriminator: "span_llm_as_judge")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.AutomationRuleEvaluatorSpanUserDefinedMetricPythonPublic), typeDiscriminator: "span_user_defined_metric_python")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.AutomationRuleEvaluatorTraceThreadLlmAsJudgePublic), typeDiscriminator: "trace_thread_llm_as_judge")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonPublic), typeDiscriminator: "trace_thread_user_defined_metric_python")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.AutomationRuleEvaluatorUserDefinedMetricPythonPublic), typeDiscriminator: "user_defined_metric_python")]
    public partial class AutomationRuleEvaluatorObjectObjectPublic
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Primary project ID (legacy field for backwards compatibility)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Primary project name (legacy field for backwards compatibility)<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Projects assigned to this rule (unique, sorted alphabetically by name)<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<global::G.ProjectReferencePublic>? Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_rate")]
        public float? SamplingRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by")]
        public string? LastUpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicActionJsonConverter))]
        public global::G.AutomationRuleEvaluatorObjectObjectPublicAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorObjectObjectPublic" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRuleEvaluatorObjectObjectPublic(
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
            global::G.AutomationRuleEvaluatorObjectObjectPublicAction action)
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
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorObjectObjectPublic" /> class.
        /// </summary>
        public AutomationRuleEvaluatorObjectObjectPublic()
        {
        }
    }
}