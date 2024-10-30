//HintName: G.Ix__ModelClient.ModelPublicServiceListNamespaceModelVersions.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__ModelClient
    {
        /// <summary>
        /// List namespace model versions<br/>
        /// Returns a paginated list of version of a model namespace that belong to the specified namespace.<br/>
        /// Contains model version and digest.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListNamespaceModelVersionsResponse> ModelPublicServiceListNamespaceModelVersionsAsync(
            string namespaceId,
            string modelId,
            int? pageSize = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}