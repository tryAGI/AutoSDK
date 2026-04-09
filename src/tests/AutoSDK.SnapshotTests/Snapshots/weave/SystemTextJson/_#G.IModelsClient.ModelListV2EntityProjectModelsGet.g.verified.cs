//HintName: G.IModelsClient.ModelListV2EntityProjectModelsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Model List<br/>
        /// List model objects.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="limit">
        /// Maximum number of models to return
        /// </param>
        /// <param name="offset">
        /// Number of models to skip
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ModelListV2EntityProjectModelsGetAsync(
            string entity,
            string project,
            int? limit = default,
            int? offset = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}