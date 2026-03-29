//HintName: G.Models.ManualEvaluationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ManualEvaluationRequest
    {
        /// <summary>
        /// Project ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// List of entity IDs (trace IDs or thread IDs) to evaluate<br/>
        /// Example: [550e8400-e29b-41d4-a716-446655440000, 550e8400-e29b-41d4-a716-446655440001]
        /// </summary>
        /// <example>[550e8400-e29b-41d4-a716-446655440000, 550e8400-e29b-41d4-a716-446655440001]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> EntityIds { get; set; }

        /// <summary>
        /// List of automation rule IDs to apply<br/>
        /// Example: [660e8400-e29b-41d4-a716-446655440000]
        /// </summary>
        /// <example>[660e8400-e29b-41d4-a716-446655440000]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> RuleIds { get; set; }

        /// <summary>
        /// Type of entity to evaluate (trace or thread)<br/>
        /// Example: trace
        /// </summary>
        /// <example>trace</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ManualEvaluationRequestEntityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ManualEvaluationRequestEntityType EntityType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManualEvaluationRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Project ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="entityIds">
        /// List of entity IDs (trace IDs or thread IDs) to evaluate<br/>
        /// Example: [550e8400-e29b-41d4-a716-446655440000, 550e8400-e29b-41d4-a716-446655440001]
        /// </param>
        /// <param name="ruleIds">
        /// List of automation rule IDs to apply<br/>
        /// Example: [660e8400-e29b-41d4-a716-446655440000]
        /// </param>
        /// <param name="entityType">
        /// Type of entity to evaluate (trace or thread)<br/>
        /// Example: trace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManualEvaluationRequest(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::System.Guid> entityIds,
            global::System.Collections.Generic.IList<global::System.Guid> ruleIds,
            global::G.ManualEvaluationRequestEntityType entityType)
        {
            this.ProjectId = projectId;
            this.EntityIds = entityIds ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            this.RuleIds = ruleIds ?? throw new global::System.ArgumentNullException(nameof(ruleIds));
            this.EntityType = entityType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManualEvaluationRequest" /> class.
        /// </summary>
        public ManualEvaluationRequest()
        {
        }
    }
}