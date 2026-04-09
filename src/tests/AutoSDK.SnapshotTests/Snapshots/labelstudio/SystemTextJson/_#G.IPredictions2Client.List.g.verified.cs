//HintName: G.IPredictions2Client.List.g.cs
#nullable enable

namespace G
{
    public partial interface IPredictions2Client
    {
        /// <summary>
        /// List predictions<br/>
        /// List all predictions and their IDs.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="task"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Prediction>> ListAsync(
            int? project = default,
            int? task = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}