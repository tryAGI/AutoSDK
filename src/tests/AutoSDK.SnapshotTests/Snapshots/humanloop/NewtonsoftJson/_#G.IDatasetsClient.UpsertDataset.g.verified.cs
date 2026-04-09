//HintName: G.IDatasetsClient.UpsertDataset.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Upsert Dataset
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetResponse> UpsertDatasetAsync(

            global::G.DatasetRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert Dataset
        /// </summary>
        /// <param name="path">
        /// Path of the Dataset.
        /// </param>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <param name="datapoints"></param>
        /// <param name="attributes"></param>
        /// <param name="versionName"></param>
        /// <param name="versionDescription"></param>
        /// <param name="tags"></param>
        /// <param name="readme"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetResponse> UpsertDatasetAsync(
            string? path = default,
            string? id = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::G.DatapointResponse>? datapoints = default,
            object? attributes = default,
            string? versionName = default,
            string? versionDescription = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? readme = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}