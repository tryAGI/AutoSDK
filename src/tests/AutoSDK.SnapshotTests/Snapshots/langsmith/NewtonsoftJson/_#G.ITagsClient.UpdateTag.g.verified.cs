//HintName: G.ITagsClient.UpdateTag.g.cs
#nullable enable

namespace G
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// Update Tag
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="tagName"></param>
        /// <param name="owner"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RepoTag> UpdateTagAsync(
            string repo,
            string tagName,
            string owner,
            global::G.RepoUpdateTagRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Tag
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="tagName"></param>
        /// <param name="owner"></param>
        /// <param name="commitId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RepoTag> UpdateTagAsync(
            string repo,
            string tagName,
            string owner,
            global::System.Guid commitId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}