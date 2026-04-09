//HintName: G.IStatsClient.StatsList.g.cs
#nullable enable

namespace G
{
    public partial interface IStatsClient
    {
        /// <summary>
        /// Retrieve memory-related statistics for the authenticated user.<br/>
        /// This endpoint returns the following statistics:<br/>
        /// - Total number of memories created<br/>
        /// - Total number of search events<br/>
        /// - Total number of add events
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task StatsListAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}