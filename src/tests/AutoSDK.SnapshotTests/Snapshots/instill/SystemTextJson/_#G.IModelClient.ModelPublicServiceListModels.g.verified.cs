//HintName: G.IModelClient.ModelPublicServiceListModels.g.cs
#nullable enable

namespace G
{
    public partial interface IModelClient
    {
        /// <summary>
        /// List models<br/>
        /// Returns a paginated list of models.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="view"></param>
        /// <param name="showDeleted"></param>
        /// <param name="filter"></param>
        /// <param name="visibility"></param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListModelsResponse> ModelPublicServiceListModelsAsync(
            int? pageSize = default,
            string? pageToken = default,
            global::G.ModelPublicServiceListModelsView? view = default,
            bool? showDeleted = default,
            string? filter = default,
            global::G.ModelPublicServiceListModelsVisibility? visibility = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}