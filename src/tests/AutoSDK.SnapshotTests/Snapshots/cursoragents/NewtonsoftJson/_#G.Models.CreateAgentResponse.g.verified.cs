//HintName: G.Models.CreateAgentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgentResponse
    {
        /// <summary>
        /// Unique identifier for the cloud agent<br/>
        /// Example: bc_abc123
        /// </summary>
        /// <example>bc_abc123</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name for the agent<br/>
        /// Example: Add README Documentation
        /// </summary>
        /// <example>Add README Documentation</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Initial status of the newly created agent<br/>
        /// Example: CREATING
        /// </summary>
        /// <example>CREATING</example>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateAgentResponseStatusJsonConverter))]
        public global::G.CreateAgentResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateAgentResponseSource Source { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateAgentResponseTarget Target { get; set; } = default!;

        /// <summary>
        /// When the agent was created<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the cloud agent<br/>
        /// Example: bc_abc123
        /// </param>
        /// <param name="name">
        /// Name for the agent<br/>
        /// Example: Add README Documentation
        /// </param>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <param name="createdAt">
        /// When the agent was created<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </param>
        /// <param name="status">
        /// Initial status of the newly created agent<br/>
        /// Example: CREATING
        /// </param>
        public CreateAgentResponse(
            string id,
            string name,
            global::G.CreateAgentResponseSource source,
            global::G.CreateAgentResponseTarget target,
            global::System.DateTime createdAt,
            global::G.CreateAgentResponseStatus status)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentResponse" /> class.
        /// </summary>
        public CreateAgentResponse()
        {
        }
    }
}