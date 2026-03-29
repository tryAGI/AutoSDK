//HintName: G.IInsightClient.InsightControllerCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IInsightClient
    {
        /// <summary>
        /// Create Insight
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.InsightControllerCreateResponse> InsightControllerCreateAsync(

            global::G.InsightControllerCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Insight
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.InsightControllerCreateResponse> InsightControllerCreateAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}