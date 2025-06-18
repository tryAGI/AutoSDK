//HintName: G.Models.MCPApprovalRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A request for human approval of a tool invocation.
    /// </summary>
    public sealed partial class MCPApprovalRequest
    {
        /// <summary>
        /// The type of the item. Always `mcp_approval_request`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MCPApprovalRequestType Type { get; set; }

        /// <summary>
        /// The unique ID of the approval request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The label of the MCP server making the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_label", Required = global::Newtonsoft.Json.Required.Always)]
        public string ServerLabel { get; set; } = default!;

        /// <summary>
        /// The name of the tool to run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A JSON string of arguments for the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments", Required = global::Newtonsoft.Json.Required.Always)]
        public string Arguments { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPApprovalRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the item. Always `mcp_approval_request`.
        /// </param>
        /// <param name="id">
        /// The unique ID of the approval request.
        /// </param>
        /// <param name="serverLabel">
        /// The label of the MCP server making the request.
        /// </param>
        /// <param name="name">
        /// The name of the tool to run.
        /// </param>
        /// <param name="arguments">
        /// A JSON string of arguments for the tool.
        /// </param>
        public MCPApprovalRequest(
            string id,
            string serverLabel,
            string name,
            string arguments,
            global::G.MCPApprovalRequestType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPApprovalRequest" /> class.
        /// </summary>
        public MCPApprovalRequest()
        {
        }
    }
}