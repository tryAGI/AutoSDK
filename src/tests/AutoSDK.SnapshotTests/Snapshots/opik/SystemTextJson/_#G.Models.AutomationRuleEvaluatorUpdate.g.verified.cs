//HintName: G.Models.AutomationRuleEvaluatorUpdate.g.cs

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
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.AutomationRuleEvaluatorUpdateLlmAsJudge), typeDiscriminator: "llm_as_judge")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.AutomationRuleEvaluatorUpdateSpanLlmAsJudge), typeDiscriminator: "span_llm_as_judge")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.AutomationRuleEvaluatorUpdateSpanUserDefinedMetricPython), typeDiscriminator: "span_user_defined_metric_python")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.AutomationRuleEvaluatorUpdateTraceThreadLlmAsJudge), typeDiscriminator: "trace_thread_llm_as_judge")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.AutomationRuleEvaluatorUpdateTraceThreadUserDefinedMetricPython), typeDiscriminator: "trace_thread_user_defined_metric_python")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.AutomationRuleEvaluatorUpdateUserDefinedMetricPython), typeDiscriminator: "user_defined_metric_python")]
    public partial class AutomationRuleEvaluatorUpdate
    {
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
        /// Primary project ID (legacy field, maintained for backwards compatibility)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Multiple project IDs (new field for multi-project support)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ProjectIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AutomationRuleEvaluatorUpdateActionJsonConverter))]
        public global::G.AutomationRuleEvaluatorUpdateAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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