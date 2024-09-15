//HintName: G.IReposClient.ReposCreateTagProtection.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Create a tag protection state for a repository<br/>
        /// This creates a tag protection state for a repository.<br/>
        /// This endpoint is only available to repository administrators.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagProtection> ReposCreateTagProtectionAsync(
            string owner,
            string repo,
            global::G.ReposCreateTagProtectionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a tag protection state for a repository<br/>
        /// This creates a tag protection state for a repository.<br/>
        /// This endpoint is only available to repository administrators.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pattern">
        /// An optional glob pattern to match against when enforcing tag protection.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagProtection> ReposCreateTagProtectionAsync(
            string owner,
            string repo,
            string pattern,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}