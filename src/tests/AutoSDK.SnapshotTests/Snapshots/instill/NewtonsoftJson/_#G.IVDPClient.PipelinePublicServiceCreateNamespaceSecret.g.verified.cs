//HintName: G.IVDPClient.PipelinePublicServiceCreateNamespaceSecret.g.cs
#nullable enable

namespace G
{
    public partial interface IVDPClient
    {
        /// <summary>
        /// Create a secret<br/>
        /// Creates a new secret under the parenthood of an namespace.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateNamespaceSecretResponse> PipelinePublicServiceCreateNamespaceSecretAsync(
            string namespaceId,
            global::G.Secret request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a secret<br/>
        /// Creates a new secret under the parenthood of an namespace.
        /// </summary>
        /// <param name="namespaceId"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateNamespaceSecretResponse> PipelinePublicServiceCreateNamespaceSecretAsync(
            string namespaceId,
            string? id = default,
            string? value = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}