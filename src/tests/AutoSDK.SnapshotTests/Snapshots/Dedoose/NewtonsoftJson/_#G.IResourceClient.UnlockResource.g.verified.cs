//HintName: G.IResourceClient.UnlockResource.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// UnlockResource<br/>
        /// UnlockResource
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UnlockResourceAsync(
            global::G.UnlockResourceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UnlockResource<br/>
        /// UnlockResource
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UnlockResourceAsync(
            global::System.Guid projectId,
            global::System.Guid resourceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}