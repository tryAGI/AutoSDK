//HintName: G.Models.GetAgentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentResponse
    {
        /// <summary>
        /// Unique identifier for the cloud agent<br/>
        /// Example: bc_abc123
        /// </summary>
        /// <example>bc_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name for the agent<br/>
        /// Example: Add README Documentation
        /// </summary>
        /// <example>Add README Documentation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Current status of the cloud agent<br/>
        /// Example: RUNNING
        /// </summary>
        /// <example>RUNNING</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetAgentResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetAgentResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetAgentResponseSource Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetAgentResponseTarget Target { get; set; }

        /// <summary>
        /// Summary of the agent's work<br/>
        /// Example: Added README.md with installation instructions and usage examples
        /// </summary>
        /// <example>Added README.md with installation instructions and usage examples</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// When the agent was created<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the cloud agent<br/>
        /// Example: bc_abc123
        /// </param>
        /// <param name="name">
        /// Name for the agent<br/>
        /// Example: Add README Documentation
        /// </param>
        /// <param name="status">
        /// Current status of the cloud agent<br/>
        /// Example: RUNNING
        /// </param>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <param name="createdAt">
        /// When the agent was created<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </param>
        /// <param name="summary">
        /// Summary of the agent's work<br/>
        /// Example: Added README.md with installation instructions and usage examples
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentResponse(
            string id,
            string name,
            global::G.GetAgentResponseStatus status,
            global::G.GetAgentResponseSource source,
            global::G.GetAgentResponseTarget target,
            global::System.DateTime createdAt,
            string? summary)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Summary = summary;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentResponse" /> class.
        /// </summary>
        public GetAgentResponse()
        {
        }
    }
}