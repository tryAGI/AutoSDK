//HintName: G.ITagClient.MergeTags.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// MergeTags<br/>
        /// MergeTags
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MergeTagsAsync(
            global::G.MergeTagsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// MergeTags<br/>
        /// MergeTags
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="tag1Id"></param>
        /// <param name="tag2Id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> MergeTagsAsync(
            global::System.Guid projectId,
            global::System.Guid tag1Id,
            global::System.Guid tag2Id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}