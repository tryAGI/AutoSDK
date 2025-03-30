//HintName: G.ITagsClient.CreateTag.g.cs
#nullable enable

namespace G
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// Create Tag
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="owner"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RepoTag> CreateTagAsync(
            string repo,
            string owner,
            global::G.RepoTagRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Tag
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="owner"></param>
        /// <param name="tagName"></param>
        /// <param name="commitId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RepoTag> CreateTagAsync(
            string repo,
            string owner,
            string tagName,
            global::System.Guid commitId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}