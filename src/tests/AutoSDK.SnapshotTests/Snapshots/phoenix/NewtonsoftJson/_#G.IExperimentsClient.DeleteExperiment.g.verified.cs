//HintName: G.IExperimentsClient.DeleteExperiment.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Delete experiment by ID
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="deleteProject">
        /// If true, also delete the project associated with the experiment that contains traces and spans for the experiment tasks.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteExperimentAsync(
            string experimentId,
            bool? deleteProject = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}