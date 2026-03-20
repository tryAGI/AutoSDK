//HintName: G.ITreesClient.GetTrees.g.cs
#nullable enable

namespace G
{
    public partial interface ITreesClient
    {

        /// <summary>
        /// Get trees
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TreeNode>> GetTreesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}