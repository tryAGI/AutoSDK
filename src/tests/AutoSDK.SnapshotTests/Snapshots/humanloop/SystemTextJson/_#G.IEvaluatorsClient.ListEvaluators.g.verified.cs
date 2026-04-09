//HintName: G.IEvaluatorsClient.ListEvaluators.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// List Evaluators
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="name"></param>
        /// <param name="sortBy"></param>
        /// <param name="order"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedEvaluatorResponse> ListEvaluatorsAsync(
            int? page = default,
            int? size = default,
            string? name = default,
            string? sortBy = default,
            global::G.ListEvaluatorsOrder? order = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}