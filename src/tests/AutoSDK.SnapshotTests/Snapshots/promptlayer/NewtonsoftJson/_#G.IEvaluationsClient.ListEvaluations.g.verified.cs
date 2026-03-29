//HintName: G.IEvaluationsClient.ListEvaluations.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// List Evaluations
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="name"></param>
        /// <param name="status">
        /// Default Value: active
        /// </param>
        /// <param name="includeRuns">
        /// Default Value: false
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListEvaluationsResponse> ListEvaluationsAsync(
            int? workspaceId = default,
            string? name = default,
            global::G.ListEvaluationsStatus? status = default,
            bool? includeRuns = default,
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}