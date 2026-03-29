//HintName: G.Models.PostLabsToolRouterSessionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostLabsToolRouterSessionResponse
    {
        /// <summary>
        /// Generated session identifier<br/>
        /// Example: session_123456789
        /// </summary>
        /// <example>session_123456789</example>
        [global::Newtonsoft.Json.JsonProperty("session_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SessionId { get; set; } = default!;

        /// <summary>
        /// MCP server endpoint URL for this specific chat session<br/>
        /// Example: https://api.composio.dev/v3/mcp/tool-router/session_123456789/mcp
        /// </summary>
        /// <example>https://api.composio.dev/v3/mcp/tool-router/session_123456789/mcp</example>
        [global::Newtonsoft.Json.JsonProperty("chat_session_mcp_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ChatSessionMcpUrl { get; set; } = default!;

        /// <summary>
        /// MCP server endpoint URL for this specific tool router instance<br/>
        /// Example: https://api.composio.dev/v3/mcp/tool-router/session_123456789/mcp
        /// </summary>
        /// <example>https://api.composio.dev/v3/mcp/tool-router/session_123456789/mcp</example>
        [global::Newtonsoft.Json.JsonProperty("tool_router_instance_mcp_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolRouterInstanceMcpUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostLabsToolRouterSessionResponse" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Generated session identifier<br/>
        /// Example: session_123456789
        /// </param>
        /// <param name="chatSessionMcpUrl">
        /// MCP server endpoint URL for this specific chat session<br/>
        /// Example: https://api.composio.dev/v3/mcp/tool-router/session_123456789/mcp
        /// </param>
        /// <param name="toolRouterInstanceMcpUrl">
        /// MCP server endpoint URL for this specific tool router instance<br/>
        /// Example: https://api.composio.dev/v3/mcp/tool-router/session_123456789/mcp
        /// </param>
        public PostLabsToolRouterSessionResponse(
            string sessionId,
            string chatSessionMcpUrl,
            string toolRouterInstanceMcpUrl)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.ChatSessionMcpUrl = chatSessionMcpUrl ?? throw new global::System.ArgumentNullException(nameof(chatSessionMcpUrl));
            this.ToolRouterInstanceMcpUrl = toolRouterInstanceMcpUrl ?? throw new global::System.ArgumentNullException(nameof(toolRouterInstanceMcpUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostLabsToolRouterSessionResponse" /> class.
        /// </summary>
        public PostLabsToolRouterSessionResponse()
        {
        }
    }
}