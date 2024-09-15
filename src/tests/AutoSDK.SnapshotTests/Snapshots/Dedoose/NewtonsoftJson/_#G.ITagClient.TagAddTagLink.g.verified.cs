//HintName: G.ITagClient.TagAddTagLink.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// AddTagLink.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="tag1Id"></param>
        /// <param name="tag2Id"></param>
        /// <param name="isParentChildLink"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagLink> TagAddTagLinkAsync(
            string? token = default,
            global::System.Guid projectId = default,
            global::System.Guid tag1Id = default,
            global::System.Guid tag2Id = default,
            bool isParentChildLink = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}