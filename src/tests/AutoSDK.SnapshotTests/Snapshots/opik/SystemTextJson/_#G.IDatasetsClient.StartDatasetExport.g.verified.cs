//HintName: G.IDatasetsClient.StartDatasetExport.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Start dataset CSV export<br/>
        /// Initiates an asynchronous CSV export job for the dataset. Returns immediately with job details for polling.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetExportJobPublic> StartDatasetExportAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}