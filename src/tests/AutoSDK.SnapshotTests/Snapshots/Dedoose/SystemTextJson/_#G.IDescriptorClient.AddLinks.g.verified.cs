//HintName: G.IDescriptorClient.AddLinks.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// AddLinks<br/>
        /// AddLinks
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddLinksAsync(
            global::G.AddLinksRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddLinks<br/>
        /// AddLinks
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="links"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddLinksAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::G.DescriptorLinkVO> links,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}