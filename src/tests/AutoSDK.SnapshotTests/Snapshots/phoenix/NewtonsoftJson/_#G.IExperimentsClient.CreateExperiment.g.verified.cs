//HintName: G.IExperimentsClient.CreateExperiment.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Create experiment on a dataset
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateExperimentResponseBody> CreateExperimentAsync(
            string datasetId,

            global::G.CreateExperimentRequestBody request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create experiment on a dataset
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="name">
        /// Name of the experiment (if omitted, a random name will be generated)
        /// </param>
        /// <param name="description">
        /// An optional description of the experiment
        /// </param>
        /// <param name="metadata">
        /// Metadata for the experiment
        /// </param>
        /// <param name="versionId">
        /// ID of the dataset version over which the experiment will be run (if omitted, the latest version will be used)
        /// </param>
        /// <param name="splits">
        /// List of dataset split identifiers (GlobalIDs or names) to filter by
        /// </param>
        /// <param name="repetitions">
        /// Number of times the experiment should be repeated for each example<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateExperimentResponseBody> CreateExperimentAsync(
            string datasetId,
            string? name = default,
            string? description = default,
            object? metadata = default,
            string? versionId = default,
            global::System.Collections.Generic.IList<string>? splits = default,
            int? repetitions = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}