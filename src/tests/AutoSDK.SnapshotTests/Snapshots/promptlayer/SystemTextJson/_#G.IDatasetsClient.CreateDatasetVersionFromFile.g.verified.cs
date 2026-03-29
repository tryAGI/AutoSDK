//HintName: G.IDatasetsClient.CreateDatasetVersionFromFile.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create Dataset Version from File
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateDatasetVersionFromFileResponse> CreateDatasetVersionFromFileAsync(

            global::G.CreateDatasetVersionFromFileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Dataset Version from File
        /// </summary>
        /// <param name="datasetGroupId">
        /// ID of the dataset group where the new version will be created
        /// </param>
        /// <param name="fileName">
        /// Name of the file being uploaded (must end with .csv or .json)
        /// </param>
        /// <param name="fileContentBase64">
        /// Base64 encoded content of the file. Maximum file size: 100MB. Supported formats: CSV, JSON
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateDatasetVersionFromFileResponse> CreateDatasetVersionFromFileAsync(
            int datasetGroupId,
            string fileName,
            string fileContentBase64,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}