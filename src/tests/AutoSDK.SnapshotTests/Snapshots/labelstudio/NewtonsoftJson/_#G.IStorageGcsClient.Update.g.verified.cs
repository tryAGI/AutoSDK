//HintName: G.IStorageGcsClient.Update.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageGcsClient
    {
        /// <summary>
        /// Update export storage<br/>
        /// Update a specific GCS export storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GCSExportStorage> UpdateAsync(
            int id,

            global::G.ApiStoragesExportGcsPartialUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update export storage<br/>
        /// Update a specific GCS export storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="bucket">
        /// GCS bucket name
        /// </param>
        /// <param name="canDeleteObjects">
        /// Deletion from storage enabled.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="description">
        /// Storage description
        /// </param>
        /// <param name="googleApplicationCredentials">
        /// The content of GOOGLE_APPLICATION_CREDENTIALS json file. Check official Google Cloud Authentication documentation for more details.
        /// </param>
        /// <param name="googleProjectId">
        /// Google project ID
        /// </param>
        /// <param name="prefix">
        /// GCS bucket prefix
        /// </param>
        /// <param name="project">
        /// Project ID
        /// </param>
        /// <param name="title">
        /// Storage title
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GCSExportStorage> UpdateAsync(
            int id,
            string? bucket = default,
            bool? canDeleteObjects = default,
            string? description = default,
            string? googleApplicationCredentials = default,
            string? googleProjectId = default,
            string? prefix = default,
            int? project = default,
            string? title = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}