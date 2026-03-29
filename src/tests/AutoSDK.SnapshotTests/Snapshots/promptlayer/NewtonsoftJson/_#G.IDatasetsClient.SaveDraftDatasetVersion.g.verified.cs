//HintName: G.IDatasetsClient.SaveDraftDatasetVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Save Draft Dataset Version
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SaveDraftDatasetVersionResponse> SaveDraftDatasetVersionAsync(

            global::G.SaveDraftDatasetVersionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save Draft Dataset Version
        /// </summary>
        /// <param name="datasetGroupId">
        /// ID of the dataset group containing the draft to save
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SaveDraftDatasetVersionResponse> SaveDraftDatasetVersionAsync(
            int datasetGroupId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}