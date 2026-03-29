//HintName: G.IApi.TunedModelsList.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Lists created tuned models.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListTunedModelsResponse> TunedModelsListAsync(
            string? filter = default,
            int? pageSize = default,
            string? pageToken = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}