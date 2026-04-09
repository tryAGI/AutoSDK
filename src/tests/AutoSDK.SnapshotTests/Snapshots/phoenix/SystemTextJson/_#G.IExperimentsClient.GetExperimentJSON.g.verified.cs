//HintName: G.IExperimentsClient.GetExperimentJSON.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Download experiment runs as a JSON file
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetExperimentJSONAsync(
            string experimentId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}