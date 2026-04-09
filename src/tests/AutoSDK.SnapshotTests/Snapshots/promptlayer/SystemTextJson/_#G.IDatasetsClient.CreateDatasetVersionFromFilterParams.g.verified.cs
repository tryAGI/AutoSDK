//HintName: G.IDatasetsClient.CreateDatasetVersionFromFilterParams.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create Dataset Version from Filter Params
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateDatasetVersionFromFilterParamsResponse> CreateDatasetVersionFromFilterParamsAsync(

            global::G.CreateDatasetVersionFromFilterParamsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Dataset Version from Filter Params
        /// </summary>
        /// <param name="datasetGroupId">
        /// ID of the dataset group where the new version will be created
        /// </param>
        /// <param name="variablesToParse">
        /// List of variables to parse from the request logs
        /// </param>
        /// <param name="promptId">
        /// Filter by specific prompt ID
        /// </param>
        /// <param name="promptVersionId">
        /// Filter by specific prompt version ID
        /// </param>
        /// <param name="promptLabelId">
        /// Filter by specific prompt label ID
        /// </param>
        /// <param name="workspaceId">
        /// Filter by specific workspace ID
        /// </param>
        /// <param name="startTime">
        /// Filter logs after this timestamp (ISO format)
        /// </param>
        /// <param name="endTime">
        /// Filter logs before this timestamp (ISO format)
        /// </param>
        /// <param name="tags">
        /// Filter by specific tags
        /// </param>
        /// <param name="metadata">
        /// Filter by metadata key-value pairs
        /// </param>
        /// <param name="scores">
        /// Filter by score ranges
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateDatasetVersionFromFilterParamsResponse> CreateDatasetVersionFromFilterParamsAsync(
            int datasetGroupId,
            global::System.Collections.Generic.IList<string>? variablesToParse = default,
            int? promptId = default,
            int? promptVersionId = default,
            int? promptLabelId = default,
            int? workspaceId = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::System.Collections.Generic.Dictionary<string, global::G.CreateDatasetVersionFromFilterParamsRequestScores2>? scores = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}