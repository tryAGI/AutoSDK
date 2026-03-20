//HintName: G.IModelClient.ModelPublicServiceListModelDefinitions.g.cs
#nullable enable

namespace G
{
    public partial interface IModelClient
    {
        /// <summary>
        /// List model definitions<br/>
        /// Returns a paginated list of model definitions.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListModelDefinitionsResponse> ModelPublicServiceListModelDefinitionsAsync(
            int? pageSize = default,
            string? pageToken = default,
            global::G.ModelPublicServiceListModelDefinitionsView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}