//HintName: G.ISandboxesClient.GetSandboxes2.g.cs
#nullable enable

namespace G
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// List all sandboxes
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="state"></param>
        /// <param name="nextToken"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ListedSandbox>> GetSandboxes2Async(
            string? metadata = default,
            global::System.Collections.Generic.IList<global::G.SandboxState>? state = default,
            string? nextToken = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}