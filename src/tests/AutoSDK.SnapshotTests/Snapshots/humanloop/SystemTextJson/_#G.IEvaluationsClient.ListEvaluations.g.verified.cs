//HintName: G.IEvaluationsClient.ListEvaluations.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// List Evaluations
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedEvaluationResponse> ListEvaluationsAsync(
            int? page = default,
            int? size = default,
            string? fileId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}