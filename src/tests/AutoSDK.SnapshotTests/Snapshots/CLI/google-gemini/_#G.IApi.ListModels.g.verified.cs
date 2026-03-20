//HintName: G.IApi.ListModels.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Lists models available through the API.
        /// </summary>
        /// <param name="pageToken"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListModelsResponse> ListModelsAsync(
            string? pageToken = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}