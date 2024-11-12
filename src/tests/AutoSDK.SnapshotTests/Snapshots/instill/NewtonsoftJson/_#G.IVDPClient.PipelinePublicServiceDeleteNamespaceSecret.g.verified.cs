//HintName: G.IVDPClient.PipelinePublicServiceDeleteNamespaceSecret.g.cs
#nullable enable

namespace G
{
    public partial interface IVDPClient
    {
        /// <summary>
        /// Delete a secret<br/>
        /// Deletes a secret, accesing it by its resource name, which is defined by<br/>
        /// the parent namespace and the ID of the secret.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="secretId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PipelinePublicServiceDeleteNamespaceSecretAsync(
            string namespaceId,
            string secretId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}