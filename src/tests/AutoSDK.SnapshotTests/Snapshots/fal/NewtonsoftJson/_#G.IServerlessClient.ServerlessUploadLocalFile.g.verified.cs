//HintName: G.IServerlessClient.ServerlessUploadLocalFile.g.cs
#nullable enable

namespace G
{
    public partial interface IServerlessClient
    {
        /// <summary>
        /// Upload local file (multipart/form-data)<br/>
        /// Uploads a local file using multipart/form-data. The file field name must be `file_upload`.
        /// </summary>
        /// <param name="targetPath">
        /// Target path (including filename)<br/>
        /// Example: datasets/images/cat.jpg
        /// </param>
        /// <param name="unzip">
        /// If true and the uploaded file is a ZIP, it will be extracted<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> ServerlessUploadLocalFileAsync(
            string targetPath,

            global::G.ServerlessUploadLocalFileRequest request,
            bool? unzip = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload local file (multipart/form-data)<br/>
        /// Uploads a local file using multipart/form-data. The file field name must be `file_upload`.
        /// </summary>
        /// <param name="targetPath">
        /// Target path (including filename)<br/>
        /// Example: datasets/images/cat.jpg
        /// </param>
        /// <param name="unzip">
        /// If true and the uploaded file is a ZIP, it will be extracted<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="fileUpload">
        /// Binary file content
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> ServerlessUploadLocalFileAsync(
            string targetPath,
            bool? unzip = default,
            object? fileUpload = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}