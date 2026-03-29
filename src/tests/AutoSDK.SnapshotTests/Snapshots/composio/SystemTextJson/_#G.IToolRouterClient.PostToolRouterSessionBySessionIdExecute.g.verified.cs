//HintName: G.IToolRouterClient.PostToolRouterSessionBySessionIdExecute.g.cs
#nullable enable

namespace G
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// Execute a tool within a tool router session<br/>
        /// Executes a specific tool within a tool router session. The toolkit is automatically inferred from the tool slug. The tool must belong to an allowed toolkit and must not be disabled in the session configuration. This endpoint validates permissions, resolves connected accounts, and executes the tool with the session context.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the tool router session. Required for public API endpoints, optional for internal endpoints where it is injected by middleware.<br/>
        /// Example: trs_LX9uJKBinWWr
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostToolRouterSessionBySessionIdExecuteResponse> PostToolRouterSessionBySessionIdExecuteAsync(
            string? sessionId,

            global::G.PostToolRouterSessionBySessionIdExecuteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute a tool within a tool router session<br/>
        /// Executes a specific tool within a tool router session. The toolkit is automatically inferred from the tool slug. The tool must belong to an allowed toolkit and must not be disabled in the session configuration. This endpoint validates permissions, resolves connected accounts, and executes the tool with the session context.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the tool router session. Required for public API endpoints, optional for internal endpoints where it is injected by middleware.<br/>
        /// Example: trs_LX9uJKBinWWr
        /// </param>
        /// <param name="toolSlug">
        /// The unique slug identifier of the tool to execute<br/>
        /// Example: GITHUB_CREATE_ISSUE
        /// </param>
        /// <param name="arguments">
        /// The arguments required by the tool<br/>
        /// Default Value: {}<br/>
        /// Example: {"repository":"octocat/Hello-World","workflow_id":"main.yml","ref":"main","inputs":{"environment":"production"}}
        /// </param>
        /// <param name="account">
        /// Account identifier to specify which connected account to use. Use the account ID (e.g. "coup_hurricane_dal_analytical") or an alias. When omitted with a single account, the default is used. When omitted with multiple accounts, an error lists available accounts.<br/>
        /// Example: coup_hurricane_dal_analytical
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostToolRouterSessionBySessionIdExecuteResponse> PostToolRouterSessionBySessionIdExecuteAsync(
            string? sessionId,
            string toolSlug,
            global::System.Collections.Generic.Dictionary<string, object?>? arguments = default,
            string? account = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}