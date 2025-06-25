//HintName: G.IModelClient.ModelPublicServiceGetNamespaceLatestModelOperation.g.cs
#nullable enable

namespace G
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Get the details of the latest long-running operation from a namespace model<br/>
        /// This method allows requesters to request the status and outcome of<br/>
        /// long-running operations in a model, such as trigger.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetNamespaceLatestModelOperationResponse> ModelPublicServiceGetNamespaceLatestModelOperationAsync(
            string namespaceId,
            string modelId,
            global::G.ModelPublicServiceGetNamespaceLatestModelOperationView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}