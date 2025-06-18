//HintName: G.Models.MCPListToolsTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool available on an MCP server.
    /// </summary>
    public sealed partial class MCPListToolsTool
    {
        /// <summary>
        /// The name of the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The description of the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The JSON schema describing the tool's input.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object InputSchema { get; set; } = default!;

        /// <summary>
        /// Additional annotations about the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotations")]
        public object? Annotations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPListToolsTool" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the tool.
        /// </param>
        /// <param name="description">
        /// The description of the tool.
        /// </param>
        /// <param name="inputSchema">
        /// The JSON schema describing the tool's input.
        /// </param>
        /// <param name="annotations">
        /// Additional annotations about the tool.
        /// </param>
        public MCPListToolsTool(
            string name,
            object inputSchema,
            string? description,
            object? annotations)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.Description = description;
            this.Annotations = annotations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPListToolsTool" /> class.
        /// </summary>
        public MCPListToolsTool()
        {
        }
    }
}