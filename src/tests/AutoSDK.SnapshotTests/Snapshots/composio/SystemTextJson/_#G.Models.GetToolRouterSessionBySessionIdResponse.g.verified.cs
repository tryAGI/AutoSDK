//HintName: G.Models.GetToolRouterSessionBySessionIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolRouterSessionBySessionIdResponse
    {
        /// <summary>
        /// The identifier of the session<br/>
        /// Example: trs_123456789
        /// </summary>
        /// <example>trs_123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetToolRouterSessionBySessionIdResponseMcp Mcp { get; set; }

        /// <summary>
        /// List of available tools in this session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_router_tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ToolRouterTools { get; set; }

        /// <summary>
        /// The session configuration including user, toolkits, and overrides
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetToolRouterSessionBySessionIdResponseConfig Config { get; set; }

        /// <summary>
        /// Experimental features
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimental")]
        public global::G.GetToolRouterSessionBySessionIdResponseExperimental? Experimental { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponse" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// The identifier of the session<br/>
        /// Example: trs_123456789
        /// </param>
        /// <param name="mcp"></param>
        /// <param name="toolRouterTools">
        /// List of available tools in this session
        /// </param>
        /// <param name="config">
        /// The session configuration including user, toolkits, and overrides
        /// </param>
        /// <param name="experimental">
        /// Experimental features
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolRouterSessionBySessionIdResponse(
            string sessionId,
            global::G.GetToolRouterSessionBySessionIdResponseMcp mcp,
            global::System.Collections.Generic.IList<string> toolRouterTools,
            global::G.GetToolRouterSessionBySessionIdResponseConfig config,
            global::G.GetToolRouterSessionBySessionIdResponseExperimental? experimental)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Mcp = mcp ?? throw new global::System.ArgumentNullException(nameof(mcp));
            this.ToolRouterTools = toolRouterTools ?? throw new global::System.ArgumentNullException(nameof(toolRouterTools));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Experimental = experimental;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponse" /> class.
        /// </summary>
        public GetToolRouterSessionBySessionIdResponse()
        {
        }
    }
}