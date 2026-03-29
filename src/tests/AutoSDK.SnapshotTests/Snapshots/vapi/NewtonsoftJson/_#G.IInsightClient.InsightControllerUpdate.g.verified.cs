//HintName: G.IInsightClient.InsightControllerUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IInsightClient
    {
        /// <summary>
        /// Update Insight
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.InsightControllerUpdateResponse> InsightControllerUpdateAsync(
            string id,

            global::G.InsightControllerUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Insight
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.InsightControllerUpdateResponse> InsightControllerUpdateAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}