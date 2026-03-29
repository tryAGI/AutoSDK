//HintName: G.Models.GuardrailWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid EntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondary_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SecondaryId { get; set; }

        /// <summary>
        /// If null, the default project is used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GuardrailWriteNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GuardrailWriteName Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GuardrailWriteResultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GuardrailWriteResult Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.JsonNode Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.JsonNode Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailWrite" /> class.
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="secondaryId"></param>
        /// <param name="name"></param>
        /// <param name="result"></param>
        /// <param name="config"></param>
        /// <param name="details"></param>
        /// <param name="projectName">
        /// If null, the default project is used
        /// </param>
        /// <param name="projectId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailWrite(
            global::System.Guid entityId,
            global::System.Guid secondaryId,
            global::G.GuardrailWriteName name,
            global::G.GuardrailWriteResult result,
            global::G.JsonNode config,
            global::G.JsonNode details,
            string? projectName,
            global::System.Guid? projectId)
        {
            this.EntityId = entityId;
            this.SecondaryId = secondaryId;
            this.ProjectName = projectName;
            this.ProjectId = projectId;
            this.Name = name;
            this.Result = result;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailWrite" /> class.
        /// </summary>
        public GuardrailWrite()
        {
        }
    }
}