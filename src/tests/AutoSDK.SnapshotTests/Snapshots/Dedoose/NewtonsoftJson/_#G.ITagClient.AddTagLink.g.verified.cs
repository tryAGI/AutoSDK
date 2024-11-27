//HintName: G.ITagClient.AddTagLink.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// AddTagLink<br/>
        /// AddTagLink
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagLink> AddTagLinkAsync(
            global::G.AddTagLinkRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddTagLink<br/>
        /// AddTagLink
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="tag1Id"></param>
        /// <param name="tag2Id"></param>
        /// <param name="isParentChildLink"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagLink> AddTagLinkAsync(
            global::System.Guid projectId,
            global::System.Guid tag1Id,
            global::System.Guid tag2Id,
            bool isParentChildLink,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}