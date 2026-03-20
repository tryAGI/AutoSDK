//HintName: G.ITagsClient.GetTags.g.cs
#nullable enable

namespace G
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// Get Tags
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="owner"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.RepoTag>> GetTagsAsync(
            string repo,
            string owner,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}