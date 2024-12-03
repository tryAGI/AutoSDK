//HintName: G.IResourceClient.GetResourcesByProject.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// GetResourcesByProject<br/>
        /// GetResourcesByProject
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Resource>> GetResourcesByProjectAsync(
            global::G.GetResourcesByProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetResourcesByProject<br/>
        /// GetResourcesByProject
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Resource>> GetResourcesByProjectAsync(
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}