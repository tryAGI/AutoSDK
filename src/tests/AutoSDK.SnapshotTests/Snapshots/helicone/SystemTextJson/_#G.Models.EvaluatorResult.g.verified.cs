//HintName: G.Models.EvaluatorResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoring_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScoringType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object LlmTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object CodeTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_mile_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object LastMileConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorResult" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="scoringType"></param>
        /// <param name="llmTemplate"></param>
        /// <param name="organizationId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="name"></param>
        /// <param name="codeTemplate"></param>
        /// <param name="lastMileConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorResult(
            string id,
            string createdAt,
            string scoringType,
            object llmTemplate,
            string organizationId,
            string updatedAt,
            string name,
            object codeTemplate,
            object lastMileConfig)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.ScoringType = scoringType ?? throw new global::System.ArgumentNullException(nameof(scoringType));
            this.LlmTemplate = llmTemplate ?? throw new global::System.ArgumentNullException(nameof(llmTemplate));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CodeTemplate = codeTemplate ?? throw new global::System.ArgumentNullException(nameof(codeTemplate));
            this.LastMileConfig = lastMileConfig ?? throw new global::System.ArgumentNullException(nameof(lastMileConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorResult" /> class.
        /// </summary>
        public EvaluatorResult()
        {
        }
    }
}