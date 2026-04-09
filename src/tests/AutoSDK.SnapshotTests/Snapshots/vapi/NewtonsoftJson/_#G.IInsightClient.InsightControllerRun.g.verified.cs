//HintName: G.IInsightClient.InsightControllerRun.g.cs
#nullable enable

namespace G
{
    public partial interface IInsightClient
    {
        /// <summary>
        /// Run Insight
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.InsightRunResponse> InsightControllerRunAsync(
            string id,

            global::G.InsightRunDTO request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Insight
        /// </summary>
        /// <param name="id"></param>
        /// <param name="formatPlan"></param>
        /// <param name="timeRangeOverride">
        /// This is the optional time range override for the insight.<br/>
        /// If provided, overrides every field in the insight's timeRange.<br/>
        /// If this is provided with missing fields, defaults will be used, not the insight's timeRange.<br/>
        /// start default - "-7d"<br/>
        /// end default - "now"<br/>
        /// step default - "day"<br/>
        /// For Pie and Text Insights, step will be ignored even if provided.<br/>
        /// Example: { start: "2025-01-01", end: "2025-01-07", step: "day" }
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.InsightRunResponse> InsightControllerRunAsync(
            string id,
            global::G.InsightRunFormatPlan? formatPlan = default,
            global::G.InsightTimeRangeWithStep? timeRangeOverride = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}