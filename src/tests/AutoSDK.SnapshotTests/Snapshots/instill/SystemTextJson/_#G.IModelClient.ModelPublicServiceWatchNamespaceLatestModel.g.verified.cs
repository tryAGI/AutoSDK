//HintName: G.IModelClient.ModelPublicServiceWatchNamespaceLatestModel.g.cs
#nullable enable

namespace G
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Watch the state of the latest model version<br/>
        /// Returns the state of the latest model version. The model resource allocation and scaling actions<br/>
        /// take some time, during which a model will be in various state. This endpoint<br/>
        /// allows clients to track the state.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WatchNamespaceLatestModelResponse> ModelPublicServiceWatchNamespaceLatestModelAsync(
            string namespaceId,
            string modelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}