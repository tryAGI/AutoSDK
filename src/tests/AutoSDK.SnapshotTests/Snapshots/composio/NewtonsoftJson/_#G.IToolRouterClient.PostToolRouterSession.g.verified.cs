//HintName: G.IToolRouterClient.PostToolRouterSession.g.cs
#nullable enable

namespace G
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// Create a new tool router session<br/>
        /// Creates a new session for the tool router feature. This endpoint initializes a new session with specified toolkits and their authentication configurations. The session provides an isolated environment for testing and managing tool routing logic with scoped MCP server access.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostToolRouterSessionResponse> PostToolRouterSessionAsync(

            global::G.PostToolRouterSessionRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new tool router session<br/>
        /// Creates a new session for the tool router feature. This endpoint initializes a new session with specified toolkits and their authentication configurations. The session provides an isolated environment for testing and managing tool routing logic with scoped MCP server access.
        /// </summary>
        /// <param name="userId">
        /// The identifier of the user who is initiating the session, ideally a unique identifier from your database like a user ID or email address<br/>
        /// Example: user_123456789
        /// </param>
        /// <param name="toolkits">
        /// Toolkit configuration - specify either enable toolkits (allowlist) or disable toolkits (denylist). Mutually exclusive.
        /// </param>
        /// <param name="authConfigs">
        /// The auth configs to use for the session. This will override the default behavior and use the given auth config when specific toolkits are being executed<br/>
        /// Example: {"gmail":"ac_1223434343","slack":"ac_23343434343434"}
        /// </param>
        /// <param name="connectedAccounts">
        /// The connected accounts to use for the session. This will override the default behaviour and use the given connected account when specific toolkits are being executed<br/>
        /// Example: {"github":"ca_34454545454545"}
        /// </param>
        /// <param name="manageConnections">
        /// Configuration for connection management settings<br/>
        /// Default Value: {"enable":true,"enable_wait_for_connections":false,"enable_connection_removal":true}
        /// </param>
        /// <param name="tools">
        /// Tool-level configuration per toolkit - either specify enable tools (whitelist), disable tools (blacklist), or filter by MCP tags for each toolkit<br/>
        /// Example: {"gmail":{"enable":["GMAIL_SEND_EMAIL","GMAIL_FETCH_EMAILS"]},"slack":{"disable":["SLACK_ADD_EMOJI"]},"slack_bot":{"tags":{"enable":["destructiveHint"],"disable":["openWorldHint"]}}}
        /// </param>
        /// <param name="tags">
        /// Global MCP tool annotation hints for filtering. Array format is treated as enabled list. Object format supports both enabled (tool must have at least one) and disabled (tool must NOT have any) lists. Toolkit-level tags override this. Toolkit enabled/disabled lists take precedence over tag filtering.<br/>
        /// Example: {"enable":["openWorldHint"],"disable":["destructiveHint"]}
        /// </param>
        /// <param name="workbench">
        /// Configuration for workbench behavior<br/>
        /// Default Value: {"enable":true,"enable_proxy_execution":true}
        /// </param>
        /// <param name="experimental">
        /// Experimental features - not stable, may be modified or removed in future versions.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostToolRouterSessionResponse> PostToolRouterSessionAsync(
            string userId,
            global::G.AnyOf<global::G.PostToolRouterSessionRequestToolkitsVariant1, global::G.PostToolRouterSessionRequestToolkitsVariant2>? toolkits = default,
            global::System.Collections.Generic.Dictionary<string, string>? authConfigs = default,
            global::System.Collections.Generic.Dictionary<string, string>? connectedAccounts = default,
            global::G.PostToolRouterSessionRequestManageConnections? manageConnections = default,
            object? tools = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestTag>, global::G.PostToolRouterSessionRequestTags>? tags = default,
            global::G.PostToolRouterSessionRequestWorkbench? workbench = default,
            global::G.PostToolRouterSessionRequestExperimental? experimental = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}