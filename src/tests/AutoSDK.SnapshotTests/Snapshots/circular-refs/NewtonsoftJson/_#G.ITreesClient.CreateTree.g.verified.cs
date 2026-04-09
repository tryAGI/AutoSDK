//HintName: G.ITreesClient.CreateTree.g.cs
#nullable enable

namespace G
{
    public partial interface ITreesClient
    {
        /// <summary>
        /// Create a tree
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TreeNode> CreateTreeAsync(

            global::G.TreeNode request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a tree
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="children"></param>
        /// <param name="parent"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TreeNode> CreateTreeAsync(
            string? id = default,
            string? name = default,
            global::System.Collections.Generic.IList<global::G.TreeNode>? children = default,
            global::G.TreeNode? parent = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}