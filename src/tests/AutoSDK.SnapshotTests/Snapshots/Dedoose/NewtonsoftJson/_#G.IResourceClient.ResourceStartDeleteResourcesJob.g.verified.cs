//HintName: G.IResourceClient.ResourceStartDeleteResourcesJob.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// StartDeleteResourcesJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResourceStartDeleteResourcesJobResponse> ResourceStartDeleteResourcesJobAsync(
            string? token = default,
            global::System.Guid projectId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? resourceIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}