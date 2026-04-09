//HintName: G.IVdpClient.PipelinePublicServiceDeleteNamespaceSecret.g.cs
#nullable enable

namespace G
{
    public partial interface IVdpClient
    {
        /// <summary>
        /// Delete a secret<br/>
        /// Deletes a secret, accesing it by its resource name, which is defined by<br/>
        /// the parent namespace and the ID of the secret.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="secretId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteNamespaceSecretResponse> PipelinePublicServiceDeleteNamespaceSecretAsync(
            string namespaceId,
            string secretId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}