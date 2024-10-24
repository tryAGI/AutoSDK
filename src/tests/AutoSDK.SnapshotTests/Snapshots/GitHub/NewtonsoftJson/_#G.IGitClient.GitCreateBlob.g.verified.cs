//HintName: G.IGitClient.GitCreateBlob.g.cs
#nullable enable

namespace G
{
    public partial interface IGitClient
    {
        /// <summary>
        /// Create a blob
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ShortBlob> GitCreateBlobAsync(
            string owner,
            string repo,
            global::G.GitCreateBlobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a blob
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="content">
        /// The new blob's content.
        /// </param>
        /// <param name="encoding">
        /// The encoding used for `content`. Currently, `"utf-8"` and `"base64"` are supported.<br/>
        /// Default Value: utf-8
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ShortBlob> GitCreateBlobAsync(
            string owner,
            string repo,
            string content,
            string? encoding = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}