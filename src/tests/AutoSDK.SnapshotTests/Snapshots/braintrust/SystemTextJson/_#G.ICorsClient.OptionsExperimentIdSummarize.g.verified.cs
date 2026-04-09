//HintName: G.ICorsClient.OptionsExperimentIdSummarize.g.cs
#nullable enable

namespace G
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/experiment/{experiment_id}/summarize`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="experimentId">
        /// Experiment id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsExperimentIdSummarizeAsync(
            global::System.Guid experimentId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}