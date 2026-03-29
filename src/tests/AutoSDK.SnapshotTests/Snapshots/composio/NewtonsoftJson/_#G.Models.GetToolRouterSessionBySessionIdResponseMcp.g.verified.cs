//HintName: G.Models.GetToolRouterSessionBySessionIdResponseMcp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolRouterSessionBySessionIdResponseMcp
    {
        /// <summary>
        /// The type of the MCP server. Can be http
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.GetToolRouterSessionBySessionIdResponseMcpType Type { get; set; }

        /// <summary>
        /// The URL of the MCP server<br/>
        /// Example: https://app.composio.dev/tool_router/v3/trs_123456789/mcp
        /// </summary>
        /// <example>https://app.composio.dev/tool_router/v3/trs_123456789/mcp</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseMcp" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the MCP server<br/>
        /// Example: https://app.composio.dev/tool_router/v3/trs_123456789/mcp
        /// </param>
        /// <param name="type">
        /// The type of the MCP server. Can be http
        /// </param>
        public GetToolRouterSessionBySessionIdResponseMcp(
            string url,
            global::G.GetToolRouterSessionBySessionIdResponseMcpType type)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseMcp" /> class.
        /// </summary>
        public GetToolRouterSessionBySessionIdResponseMcp()
        {
        }
    }
}