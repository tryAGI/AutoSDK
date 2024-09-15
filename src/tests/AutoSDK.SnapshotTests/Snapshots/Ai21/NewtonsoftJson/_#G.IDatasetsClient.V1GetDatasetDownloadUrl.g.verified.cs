//HintName: G.IDatasetsClient.V1GetDatasetDownloadUrl.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Dataset Download Url
        /// </summary>
        /// <param name="datasetPid"></param>
        /// <param name="datasetName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.V1GetDatasetDownloadUrlResponse> V1GetDatasetDownloadUrlAsync(
            string datasetPid,
            string datasetName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}