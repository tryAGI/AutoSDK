//HintName: G.IStatsClient.LabelDistributionCounts.g.cs
#nullable enable

namespace G
{
    public partial interface IStatsClient
    {
        /// <summary>
        /// ✨ Get label distribution counts<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Returns counts and percentages for requested label choices, from both annotations and predictions. Supports either pagination (`limit`, `offset`) or targeted fetches via explicit `choice_keys`.
        /// </summary>
        /// <param name="choiceKeys"></param>
        /// <param name="id"></param>
        /// <param name="limit"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LabelDistributionCountsResponse> LabelDistributionCountsAsync(
            int id,
            string? choiceKeys = default,
            int? limit = default,
            int? offset = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}