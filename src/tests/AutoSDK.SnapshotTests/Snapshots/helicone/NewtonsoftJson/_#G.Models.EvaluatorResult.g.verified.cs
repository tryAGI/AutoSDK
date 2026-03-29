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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scoring_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ScoringType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_template", Required = global::Newtonsoft.Json.Required.Always)]
        public object LlmTemplate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_template", Required = global::Newtonsoft.Json.Required.Always)]
        public object CodeTemplate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_mile_config", Required = global::Newtonsoft.Json.Required.Always)]
        public object LastMileConfig { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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