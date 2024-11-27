//HintName: G.IResourceClient.UpdateResource.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// UpdateResource<br/>
        /// UpdateResource
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Resource> UpdateResourceAsync(
            global::G.UpdateResourceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateResource<br/>
        /// UpdateResource
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Resource> UpdateResourceAsync(
            global::System.Guid projectId,
            global::System.Guid resourceId,
            string title,
            string description,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}