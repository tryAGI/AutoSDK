//HintName: G.ISandboxesClient.CreateSandboxes.g.cs
#nullable enable

namespace G
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Create a sandbox from the template
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Sandbox> CreateSandboxesAsync(

            global::G.NewSandbox request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a sandbox from the template
        /// </summary>
        /// <param name="templateID">
        /// Identifier of the required template
        /// </param>
        /// <param name="timeout">
        /// Time to live for the sandbox in seconds.<br/>
        /// Default Value: 15
        /// </param>
        /// <param name="autoPause">
        /// Automatically pauses the sandbox after the timeout<br/>
        /// Default Value: false
        /// </param>
        /// <param name="autoResume">
        /// Auto-resume configuration for paused sandboxes.
        /// </param>
        /// <param name="secure">
        /// Secure all system communication with sandbox
        /// </param>
        /// <param name="allowInternetAccess">
        /// Allow sandbox to access the internet. When set to false, it behaves the same as specifying denyOut to 0.0.0.0/0 in the network config.
        /// </param>
        /// <param name="network"></param>
        /// <param name="metadata"></param>
        /// <param name="envVars"></param>
        /// <param name="mcp">
        /// MCP configuration for the sandbox
        /// </param>
        /// <param name="volumeMounts"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Sandbox> CreateSandboxesAsync(
            string templateID,
            int? timeout = default,
            bool? autoPause = default,
            global::G.SandboxAutoResumeConfig? autoResume = default,
            bool? secure = default,
            bool? allowInternetAccess = default,
            global::G.SandboxNetworkConfig? network = default,
            object? metadata = default,
            object? envVars = default,
            global::G.Mcp? mcp = default,
            global::System.Collections.Generic.IList<global::G.SandboxVolumeMount>? volumeMounts = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}