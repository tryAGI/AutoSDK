//HintName: G.IInsightClient.InsightControllerPreview.g.cs
#nullable enable

namespace G
{
    public partial interface IInsightClient
    {
        /// <summary>
        /// Preview Insight
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.InsightRunResponse> InsightControllerPreviewAsync(

            global::G.InsightControllerPreviewRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview Insight
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.InsightRunResponse> InsightControllerPreviewAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}