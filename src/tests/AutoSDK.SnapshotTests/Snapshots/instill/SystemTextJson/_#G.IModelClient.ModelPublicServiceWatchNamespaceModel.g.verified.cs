//HintName: G.IModelClient.ModelPublicServiceWatchNamespaceModel.g.cs
#nullable enable

namespace G
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Watch the state of a model version<br/>
        /// Returns the state of a model. The model resource allocation and scaling actions take some<br/>
        /// time, during which a model will be in various state. This endpoint<br/>
        /// allows clients to track the state.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WatchNamespaceModelResponse> ModelPublicServiceWatchNamespaceModelAsync(
            string namespaceId,
            string modelId,
            string version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}