//HintName: G.IExperimentsClient.GetExperimentById.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Get experiment by id<br/>
        /// Get experiment by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExperimentPublic> GetExperimentByIdAsync(
            global::System.Guid id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}