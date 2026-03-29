//HintName: G.IDatasetsClient.DownloadDatasetExport.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Download dataset export file<br/>
        /// Downloads the exported CSV file for a completed export job. This endpoint proxies the file download to avoid exposing internal storage URLs.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadDatasetExportAsync(
            global::System.Guid jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}