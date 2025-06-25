//HintName: G.Models.WebhookToolConfigInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A webhook tool is a tool that calls an external webhook from our server
    /// </summary>
    public sealed partial class WebhookToolConfigInput
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookToolConfigInputTypeJsonConverter))]
        public global::G.WebhookToolConfigInputType? Type { get; set; }

        /// <summary>
        /// Configuration for a webhook that will be called by an LLM tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookToolApiSchemaConfigInput ApiSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public global::G.DynamicVariablesConfig? DynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookToolConfigInput" /> class.
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
        /// Configuration for a webhook that will be called by an LLM tool.
        /// </param>
        /// <param name="dynamicVariables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookToolConfigInput(
            string name,
            string description,
            global::G.WebhookToolApiSchemaConfigInput apiSchema,
            string? id,
            int? responseTimeoutSecs,
            global::G.WebhookToolConfigInputType? type,
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
        /// Initializes a new instance of the <see cref="WebhookToolConfigInput" /> class.
        /// </summary>
        public WebhookToolConfigInput()
        {
        }
    }
}