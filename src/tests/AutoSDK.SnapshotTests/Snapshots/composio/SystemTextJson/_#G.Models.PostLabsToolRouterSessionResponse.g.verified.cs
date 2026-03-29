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
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// MCP server endpoint URL for this specific chat session<br/>
        /// Example: https://api.composio.dev/v3/mcp/tool-router/session_123456789/mcp
        /// </summary>
        /// <example>https://api.composio.dev/v3/mcp/tool-router/session_123456789/mcp</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_session_mcp_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChatSessionMcpUrl { get; set; }

        /// <summary>
        /// MCP server endpoint URL for this specific tool router instance<br/>
        /// Example: https://api.composio.dev/v3/mcp/tool-router/session_123456789/mcp
        /// </summary>
        /// <example>https://api.composio.dev/v3/mcp/tool-router/session_123456789/mcp</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_router_instance_mcp_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolRouterInstanceMcpUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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