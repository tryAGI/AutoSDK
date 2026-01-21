//HintName: G.Models.WebhookToolConfigOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A webhook tool is a tool that calls an external webhook from our server<br/>
    /// Example: {"response_timeout_secs":20,"type":"webhook"}
    /// </summary>
    public sealed partial class WebhookToolConfigOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The maximum time in seconds to wait for the tool call to complete. Must be between 5 and 120 seconds (inclusive).<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_timeout_secs")]
        public int? ResponseTimeoutSecs { get; set; }

        /// <summary>
        /// The type of tool<br/>
        /// Default Value: webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The schema for the outgoing webhoook, including parameters and URL specification<br/>
        /// Example: {"method":"GET","path_params_schema":{"agent_id":{"type":"string"}},"query_params_schema":{"param1":{"type":"string"}},"request_body_schema":{"param1":{"type":"string"}},"request_headers":{"Authorization":"Bearer {api_key}"},"url":"https://example.com/agents/{agent_id}"}
        /// </summary>
        /// <example>{"method":"GET","path_params_schema":{"agent_id":{"type":"string"}},"query_params_schema":{"param1":{"type":"string"}},"request_body_schema":{"param1":{"type":"string"}},"request_headers":{"Authorization":"Bearer {api_key}"},"url":"https://example.com/agents/{agent_id}"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookToolApiSchemaConfigOutput ApiSchema { get; set; }

        /// <summary>
        /// Configuration for dynamic variables<br/>
        /// Example: {"dynamic_variable_placeholders":{"user_name":"John Doe"}}
        /// </summary>
        /// <example>{"dynamic_variable_placeholders":{"user_name":"John Doe"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public global::G.DynamicVariablesConfig? DynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookToolConfigOutput" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="responseTimeoutSecs">
        /// The maximum time in seconds to wait for the tool call to complete. Must be between 5 and 120 seconds (inclusive).<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="type">
        /// The type of tool<br/>
        /// Default Value: webhook
        /// </param>
        /// <param name="apiSchema">
        /// The schema for the outgoing webhoook, including parameters and URL specification<br/>
        /// Example: {"method":"GET","path_params_schema":{"agent_id":{"type":"string"}},"query_params_schema":{"param1":{"type":"string"}},"request_body_schema":{"param1":{"type":"string"}},"request_headers":{"Authorization":"Bearer {api_key}"},"url":"https://example.com/agents/{agent_id}"}
        /// </param>
        /// <param name="dynamicVariables">
        /// Configuration for dynamic variables<br/>
        /// Example: {"dynamic_variable_placeholders":{"user_name":"John Doe"}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookToolConfigOutput(
            string name,
            string description,
            global::G.WebhookToolApiSchemaConfigOutput apiSchema,
            string? id,
            int? responseTimeoutSecs,
            string? type,
            global::G.DynamicVariablesConfig? dynamicVariables)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ApiSchema = apiSchema ?? throw new global::System.ArgumentNullException(nameof(apiSchema));
            this.Id = id;
            this.ResponseTimeoutSecs = responseTimeoutSecs;
            this.Type = type;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookToolConfigOutput" /> class.
        /// </summary>
        public WebhookToolConfigOutput()
        {
        }
    }
}