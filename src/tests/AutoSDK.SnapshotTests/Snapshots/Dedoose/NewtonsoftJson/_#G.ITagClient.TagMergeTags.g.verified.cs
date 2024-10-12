//HintName: G.ITagClient.TagMergeTags.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// MergeTags.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="tag1Id"></param>
        /// <param name="tag2Id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TagMergeTagsAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? tag1Id = default,
            global::System.Guid? tag2Id = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}