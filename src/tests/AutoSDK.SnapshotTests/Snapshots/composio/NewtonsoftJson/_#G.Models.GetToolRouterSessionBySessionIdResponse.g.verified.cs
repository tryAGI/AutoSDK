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
        [global::Newtonsoft.Json.JsonProperty("session_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SessionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetToolRouterSessionBySessionIdResponseMcp Mcp { get; set; } = default!;

        /// <summary>
        /// List of available tools in this session
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_router_tools", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ToolRouterTools { get; set; } = default!;

        /// <summary>
        /// The session configuration including user, toolkits, and overrides
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetToolRouterSessionBySessionIdResponseConfig Config { get; set; } = default!;

        /// <summary>
        /// Experimental features
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experimental")]
        public global::G.GetToolRouterSessionBySessionIdResponseExperimental? Experimental { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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