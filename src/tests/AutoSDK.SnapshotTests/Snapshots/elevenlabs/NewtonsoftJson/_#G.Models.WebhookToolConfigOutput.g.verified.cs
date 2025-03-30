//HintName: G.Models.WebhookToolConfigOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A webhook tool is a tool that calls an external webhook from our server
    /// </summary>
    public sealed partial class WebhookToolConfigOutput
    {
        /// <summary>
        /// The type of tool<br/>
        /// Default Value: webhook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.WebhookToolConfigOutputType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Configuration for a webhook that will be called by an LLM tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookToolApiSchemaConfigOutput ApiSchema { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dynamic_variables")]
        public global::G.DynamicVariablesConfig? DynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookToolConfigOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool<br/>
        /// Default Value: webhook
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="apiSchema">
        /// Configuration for a webhook that will be called by an LLM tool.
        /// </param>
        /// <param name="dynamicVariables"></param>
        public WebhookToolConfigOutput(
            string name,
            string description,
            global::G.WebhookToolApiSchemaConfigOutput apiSchema,
            global::G.WebhookToolConfigOutputType? type,
            global::G.DynamicVariablesConfig? dynamicVariables)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ApiSchema = apiSchema ?? throw new global::System.ArgumentNullException(nameof(apiSchema));
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