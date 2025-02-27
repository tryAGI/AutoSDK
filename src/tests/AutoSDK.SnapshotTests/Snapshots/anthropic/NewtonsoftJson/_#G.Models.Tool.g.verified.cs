//HintName: G.Models.Tool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Tool
    {
        /// <summary>
        /// Description of what this tool does.<br/>
        /// Tool descriptions should be as detailed as possible. The more information that the model has about what the tool is and how to use it, the better it will perform. You can use natural language descriptions to reinforce important aspects of the tool input JSON schema.<br/>
        /// Example: Get the current weather in a given location
        /// </summary>
        /// <example>Get the current weather in a given location</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in tool_use blocks.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// [JSON schema](https://json-schema.org/draft/2020-12) for this tool's input.<br/>
        /// This defines the shape of the `input` that your tool accepts and that the model will produce.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InputSchema InputSchema { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.CacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool" /> class.
        /// </summary>
        /// <param name="description">
        /// Description of what this tool does.<br/>
        /// Tool descriptions should be as detailed as possible. The more information that the model has about what the tool is and how to use it, the better it will perform. You can use natural language descriptions to reinforce important aspects of the tool input JSON schema.<br/>
        /// Example: Get the current weather in a given location
        /// </param>
        /// <param name="name">
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in tool_use blocks.
        /// </param>
        /// <param name="inputSchema">
        /// [JSON schema](https://json-schema.org/draft/2020-12) for this tool's input.<br/>
        /// This defines the shape of the `input` that your tool accepts and that the model will produce.
        /// </param>
        /// <param name="cacheControl"></param>
        public Tool(
            string name,
            global::G.InputSchema inputSchema,
            string? description,
            global::G.CacheControlEphemeral? cacheControl)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.Description = description;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool" /> class.
        /// </summary>
        public Tool()
        {
        }
    }
}