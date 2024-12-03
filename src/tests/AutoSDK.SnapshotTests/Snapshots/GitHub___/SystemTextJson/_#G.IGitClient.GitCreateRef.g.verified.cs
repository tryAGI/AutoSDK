//HintName: G.IGitClient.GitCreateRef.g.cs
#nullable enable

namespace G
{
    public partial interface IGitClient
    {
        /// <summary>
        /// Create a reference<br/>
        /// Creates a reference for your repository. You are unable to create new references for empty repositories, even if the commit SHA-1 hash used exists. Empty repositories are repositories without branches.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GitRef> GitCreateRefAsync(
            string owner,
            string repo,
            global::G.GitCreateRefRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a reference<br/>
        /// Creates a reference for your repository. You are unable to create new references for empty repositories, even if the commit SHA-1 hash used exists. Empty repositories are repositories without branches.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref">
        /// The name of the fully qualified reference (ie: `refs/heads/master`). If it doesn't start with 'refs' and have at least two slashes, it will be rejected.
        /// </param>
        /// <param name="sha">
        /// The SHA1 value for this reference.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GitRef> GitCreateRefAsync(
            string owner,
            string repo,
            string @ref,
            string sha,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}