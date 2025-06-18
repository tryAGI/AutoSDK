//HintName: G.Models.MCPToolCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An invocation of a tool on an MCP server.
    /// </summary>
    public sealed partial class MCPToolCall
    {
        /// <summary>
        /// The type of the item. Always `mcp_call`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MCPToolCallType Type { get; set; }

        /// <summary>
        /// The unique ID of the tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The label of the MCP server running the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_label", Required = global::Newtonsoft.Json.Required.Always)]
        public string ServerLabel { get; set; } = default!;

        /// <summary>
        /// The name of the tool that was run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A JSON string of the arguments passed to the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments", Required = global::Newtonsoft.Json.Required.Always)]
        public string Arguments { get; set; } = default!;

        /// <summary>
        /// The output from the tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public string? Output { get; set; }

        /// <summary>
        /// The error from the tool call, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolCall" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the item. Always `mcp_call`.
        /// </param>
        /// <param name="id">
        /// The unique ID of the tool call.
        /// </param>
        /// <param name="serverLabel">
        /// The label of the MCP server running the tool.
        /// </param>
        /// <param name="name">
        /// The name of the tool that was run.
        /// </param>
        /// <param name="arguments">
        /// A JSON string of the arguments passed to the tool.
        /// </param>
        /// <param name="output">
        /// The output from the tool call.
        /// </param>
        /// <param name="error">
        /// The error from the tool call, if any.
        /// </param>
        public MCPToolCall(
            string id,
            string serverLabel,
            string name,
            string arguments,
            global::G.MCPToolCallType type,
            string? output,
            string? error)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Type = type;
            this.Output = output;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolCall" /> class.
        /// </summary>
        public MCPToolCall()
        {
        }
    }
}