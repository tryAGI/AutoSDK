//HintName: G.IResourceClient.AddResource.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// AddResource<br/>
        /// AddResource
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Resource> AddResourceAsync(
            global::G.AddResourceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddResource<br/>
        /// AddResource
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="resourceType"></param>
        /// <param name="fileURL"></param>
        /// <param name="length"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Resource> AddResourceAsync(
            global::System.Guid projectId,
            global::System.Guid userId,
            string title,
            string description,
            int resourceType,
            string fileURL,
            int length,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}