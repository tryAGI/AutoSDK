//HintName: G.IModelClient.ModelPublicServiceDeleteNamespaceModelVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Delete a model version<br/>
        /// Deletes a model version, accesing it by its resource name, which is defined by the<br/>
        /// parent namespace and the ID of the model, and version.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteNamespaceModelVersionResponse> ModelPublicServiceDeleteNamespaceModelVersionAsync(
            string namespaceId,
            string modelId,
            string version,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}