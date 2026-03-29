//HintName: G.Models.AutomationRuleEvaluatorWrite.g.cs

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
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.AutomationRuleEvaluatorLlmAsJudgeWrite), typeDiscriminator: "llm_as_judge")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.AutomationRuleEvaluatorSpanLlmAsJudgeWrite), typeDiscriminator: "span_llm_as_judge")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.AutomationRuleEvaluatorSpanUserDefinedMetricPythonWrite), typeDiscriminator: "span_user_defined_metric_python")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.AutomationRuleEvaluatorTraceThreadLlmAsJudgeWrite), typeDiscriminator: "trace_thread_llm_as_judge")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWrite), typeDiscriminator: "trace_thread_user_defined_metric_python")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.AutomationRuleEvaluatorUserDefinedMetricPythonWrite), typeDiscriminator: "user_defined_metric_python")]
    public partial class AutomationRuleEvaluatorWrite
    {
        /// <summary>
        /// Primary project ID (legacy field for backwards compatibility)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Project IDs for write operations (used when creating/updating rules)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ProjectIds { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AutomationRuleEvaluatorWriteActionJsonConverter))]
        public global::G.AutomationRuleEvaluatorWriteAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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