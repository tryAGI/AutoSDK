//HintName: G.IPrompts2Client.BatchFailedPredictions.g.cs
#nullable enable

namespace G
{
    public partial interface IPrompts2Client
    {
        /// <summary>
        /// ✨ Create batch of failed predictions<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Create a new batch of failed predictions.
        /// </summary>
        /// <param name="numFailedPredictions"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchFailedPredictions> BatchFailedPredictionsAsync(

            global::G.BatchFailedPredictionsRequestRequest request,
            int? numFailedPredictions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Create batch of failed predictions<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Create a new batch of failed predictions.
        /// </summary>
        /// <param name="numFailedPredictions"></param>
        /// <param name="failedPredictions"></param>
        /// <param name="jobId"></param>
        /// <param name="modelrunId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchFailedPredictions> BatchFailedPredictionsAsync(
            global::System.Collections.Generic.IList<object> failedPredictions,
            int modelrunId,
            int? numFailedPredictions = default,
            string? jobId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}