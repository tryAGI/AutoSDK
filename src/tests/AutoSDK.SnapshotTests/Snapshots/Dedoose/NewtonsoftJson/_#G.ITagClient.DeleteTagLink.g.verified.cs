//HintName: G.ITagClient.DeleteTagLink.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// DeleteTagLink<br/>
        /// DeleteTagLink
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagLink> DeleteTagLinkAsync(
            global::G.DeleteTagLinkRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DeleteTagLink<br/>
        /// DeleteTagLink
        /// </summary>
        /// <param name="currentProjectId"></param>
        /// <param name="link"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagLink> DeleteTagLinkAsync(
            global::System.Guid currentProjectId,
            global::G.TagLink link,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}