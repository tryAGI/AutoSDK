//HintName: G.IVdpClient.PipelinePublicServiceUpdateNamespaceSecret.g.cs
#nullable enable

namespace G
{
    public partial interface IVdpClient
    {
        /// <summary>
        /// Update a secret<br/>
        /// Udpates a secret, accessing it by its resource name, which is defined by<br/>
        /// In REST requests, only the supplied secret fields will be taken into<br/>
        /// account when updating the resource.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="secretId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateNamespaceSecretResponse> PipelinePublicServiceUpdateNamespaceSecretAsync(
            string namespaceId,
            string secretId,

            global::G.Secret request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a secret<br/>
        /// Udpates a secret, accessing it by its resource name, which is defined by<br/>
        /// In REST requests, only the supplied secret fields will be taken into<br/>
        /// account when updating the resource.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="secretId"></param>
        /// <param name="id">
        /// Secret resource ID (used in `name` as the last segment). This conforms<br/>
        /// to RFC-1034, which restricts to letters, numbers, and hyphen, with the<br/>
        /// first character a letter, the last a letter or a number, and a 63<br/>
        /// character maximum.
        /// </param>
        /// <param name="value">
        /// The value of the secret, which is input-only and will never be returned in API responses.
        /// </param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateNamespaceSecretResponse> PipelinePublicServiceUpdateNamespaceSecretAsync(
            string namespaceId,
            string secretId,
            string? id = default,
            string? value = default,
            string? description = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}