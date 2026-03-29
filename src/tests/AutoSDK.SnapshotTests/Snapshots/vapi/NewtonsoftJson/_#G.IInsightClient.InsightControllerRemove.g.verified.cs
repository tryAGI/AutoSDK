//HintName: G.IInsightClient.InsightControllerRemove.g.cs
#nullable enable

namespace G
{
    public partial interface IInsightClient
    {
        /// <summary>
        /// Delete Insight
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.InsightControllerRemoveResponse> InsightControllerRemoveAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}