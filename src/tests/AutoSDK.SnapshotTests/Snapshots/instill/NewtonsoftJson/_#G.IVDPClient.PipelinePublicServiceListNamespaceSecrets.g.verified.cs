//HintName: G.IVDPClient.PipelinePublicServiceListNamespaceSecrets.g.cs
#nullable enable

namespace G
{
    public partial interface IVDPClient
    {
        /// <summary>
        /// List secrets<br/>
        /// Returns a paginated list of secrets that belong to the specified<br/>
        /// namespace.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListNamespaceSecretsResponse> PipelinePublicServiceListNamespaceSecretsAsync(
            string namespaceId,
            int? pageSize = default,
            string? pageToken = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}