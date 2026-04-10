//HintName: G.IClusterClient.ClusterGetStatistics.g.cs
#nullable enable

namespace G
{
    public partial interface IClusterClient
    {
        /// <summary>
        /// See Raft cluster statistics<br/>
        /// Returns Raft cluster statistics of Weaviate DB.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClusterStatisticsResponse> ClusterGetStatisticsAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}