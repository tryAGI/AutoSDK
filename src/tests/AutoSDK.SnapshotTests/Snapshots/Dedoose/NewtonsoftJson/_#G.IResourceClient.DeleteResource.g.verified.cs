//HintName: G.IResourceClient.DeleteResource.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// DeleteResource<br/>
        /// DeleteResource
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Resource> DeleteResourceAsync(
            global::G.DeleteResourceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DeleteResource<br/>
        /// DeleteResource
        /// </summary>
        /// <param name="currentProjectId"></param>
        /// <param name="resource"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Resource> DeleteResourceAsync(
            global::System.Guid currentProjectId,
            global::G.Resource resource,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}