//HintName: G.Models.MCPTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A simple wrapper around MCP's tool definition (to avoid conflict with our own)
    /// </summary>
    public sealed partial class MCPTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputSchema", Required = global::Newtonsoft.Json.Required.Always)]
        public object InputSchema { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputSchema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotations")]
        public global::G.ToolAnnotations? Annotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// Schema health status for OpenAI strict mode
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("health")]
        public global::G.MCPToolHealth2? Health { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPTool" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inputSchema"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="outputSchema"></param>
        /// <param name="annotations"></param>
        /// <param name="meta"></param>
        /// <param name="health">
        /// Schema health status for OpenAI strict mode
        /// </param>
        public MCPTool(
            string name,
            object inputSchema,
            string? title,
            string? description,
            object? outputSchema,
            global::G.ToolAnnotations? annotations,
            object? meta,
            global::G.MCPToolHealth2? health)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Title = title;
            this.Description = description;
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.OutputSchema = outputSchema;
            this.Annotations = annotations;
            this.Meta = meta;
            this.Health = health;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPTool" /> class.
        /// </summary>
        public MCPTool()
        {
        }
    }
}