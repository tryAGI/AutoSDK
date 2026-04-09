//HintName: G.IStatsClient.ModelVersionGroundTruthAgreement.g.cs
#nullable enable

namespace G
{
    public partial interface IStatsClient
    {
        /// <summary>
        /// ✨ Get model-version ground truth agreement<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Get agreement between a given model version and ground truth annotations in the project for overlapping tasks.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="modelVersion"></param>
        /// <param name="perLabel">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiProjectsModelStatsAgreementGroundtruthRetrieveResponse> ModelVersionGroundTruthAgreementAsync(
            int id,
            string modelVersion,
            bool? perLabel = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}