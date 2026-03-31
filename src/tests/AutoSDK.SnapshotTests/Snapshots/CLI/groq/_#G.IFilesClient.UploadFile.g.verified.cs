//HintName: G.IFilesClient.UploadFile.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload a file that can be used across various endpoints.<br/>
        /// The Batch API only supports `.jsonl` files up to 100 MB in size. The input also has a specific required [format](/docs/batch).<br/>
        /// Please contact us if you need to increase these storage limits.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.File> UploadFileAsync(

            global::G.CreateFileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file that can be used across various endpoints.<br/>
        /// The Batch API only supports `.jsonl` files up to 100 MB in size. The input also has a specific required [format](/docs/batch).<br/>
        /// Please contact us if you need to increase these storage limits.
        /// </summary>
        /// <param name="file">
        /// The File object (not file name) to be uploaded.
        /// </param>
        /// <param name="filename">
        /// The File object (not file name) to be uploaded.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the uploaded file.<br/>
        /// Use "batch" for [Batch API](/docs/api-reference#batches).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.File> UploadFileAsync(
            byte[] file,
            string filename,
            global::G.CreateFileRequestPurpose purpose = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}