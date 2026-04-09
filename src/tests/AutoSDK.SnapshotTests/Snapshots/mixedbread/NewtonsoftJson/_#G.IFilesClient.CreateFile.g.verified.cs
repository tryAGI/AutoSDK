//HintName: G.IFilesClient.CreateFile.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload file<br/>
        /// Upload a new file.<br/>
        /// Args:<br/>
        ///     file: The file to upload.<br/>
        /// Returns:<br/>
        ///     FileResponse: The response containing the details of the uploaded file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileObject> CreateFileAsync(

            global::G.BodyCreateFile request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload file<br/>
        /// Upload a new file.<br/>
        /// Args:<br/>
        ///     file: The file to upload.<br/>
        /// Returns:<br/>
        ///     FileResponse: The response containing the details of the uploaded file.
        /// </summary>
        /// <param name="file">
        /// The file to upload
        /// </param>
        /// <param name="filename">
        /// The file to upload
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileObject> CreateFileAsync(
            byte[] file,
            string filename,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}