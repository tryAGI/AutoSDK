//HintName: G.IStorageLocalClient.Update.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageLocalClient
    {
        /// <summary>
        /// Update export storage<br/>
        /// Update a specific local file export storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LocalFilesExportStorage> UpdateAsync(
            int id,

            global::G.ApiStoragesExportLocalfilesPartialUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update export storage<br/>
        /// Update a specific local file export storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description">
        /// Storage description
        /// </param>
        /// <param name="path">
        /// Path to local directory
        /// </param>
        /// <param name="project">
        /// Project ID
        /// </param>
        /// <param name="regexFilter">
        /// Regex for filtering objects
        /// </param>
        /// <param name="title">
        /// Storage title
        /// </param>
        /// <param name="useBlobUrls">
        /// Interpret objects as BLOBs and generate URLs. For example, if your directory contains images, you can use this option to generate URLs for these images. If set to False, it will read the content of the file and load it into Label Studio.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LocalFilesExportStorage> UpdateAsync(
            int id,
            string? description = default,
            string? path = default,
            int? project = default,
            string? regexFilter = default,
            string? title = default,
            bool? useBlobUrls = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}