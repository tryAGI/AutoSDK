//HintName: G.IDescriptorClient.GetResourceLinks.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// GetResourceLinks<br/>
        /// GetResourceLinks
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetResourceLinksAsync(
            global::G.GetResourceLinksRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetResourceLinks<br/>
        /// GetResourceLinks
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetResourceLinksAsync(
            global::System.Guid projectId,
            global::System.Guid resourceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}