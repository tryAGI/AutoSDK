//HintName: G.IDatasetsClient.CreateDraftDatasetVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create Draft Dataset Version
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateDraftDatasetVersionResponse> CreateDraftDatasetVersionAsync(

            global::G.CreateDraftDatasetVersionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Draft Dataset Version
        /// </summary>
        /// <param name="datasetGroupId">
        /// ID of the dataset group to create a draft version for
        /// </param>
        /// <param name="sourceDatasetId">
        /// Optional. ID of an existing dataset version to copy rows from. Must belong to the same dataset group.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateDraftDatasetVersionResponse> CreateDraftDatasetVersionAsync(
            int datasetGroupId,
            int? sourceDatasetId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}