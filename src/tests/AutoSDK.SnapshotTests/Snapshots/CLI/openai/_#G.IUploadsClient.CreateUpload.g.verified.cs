//HintName: G.IUploadsClient.CreateUpload.g.cs
#nullable enable

namespace G
{
    public partial interface IUploadsClient
    {
        /// <summary>
        /// Creates an intermediate [Upload](/docs/api-reference/uploads/object) object<br/>
        /// that you can add [Parts](/docs/api-reference/uploads/part-object) to.<br/>
        /// Currently, an Upload can accept at most 8 GB in total and expires after an<br/>
        /// hour after you create it.<br/>
        /// Once you complete the Upload, we will create a<br/>
        /// [File](/docs/api-reference/files/object) object that contains all the parts<br/>
        /// you uploaded. This File is usable in the rest of our platform as a regular<br/>
        /// File object.<br/>
        /// For certain `purpose` values, the correct `mime_type` must be specified. <br/>
        /// Please refer to documentation for the <br/>
        /// [supported MIME types for your use case](/docs/assistants/tools/file-search#supported-files).<br/>
        /// For guidance on the proper filename extensions for each purpose, please<br/>
        /// follow the documentation on [creating a<br/>
        /// File](/docs/api-reference/files/create).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Upload> CreateUploadAsync(
            global::G.CreateUploadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates an intermediate [Upload](/docs/api-reference/uploads/object) object<br/>
        /// that you can add [Parts](/docs/api-reference/uploads/part-object) to.<br/>
        /// Currently, an Upload can accept at most 8 GB in total and expires after an<br/>
        /// hour after you create it.<br/>
        /// Once you complete the Upload, we will create a<br/>
        /// [File](/docs/api-reference/files/object) object that contains all the parts<br/>
        /// you uploaded. This File is usable in the rest of our platform as a regular<br/>
        /// File object.<br/>
        /// For certain `purpose` values, the correct `mime_type` must be specified. <br/>
        /// Please refer to documentation for the <br/>
        /// [supported MIME types for your use case](/docs/assistants/tools/file-search#supported-files).<br/>
        /// For guidance on the proper filename extensions for each purpose, please<br/>
        /// follow the documentation on [creating a<br/>
        /// File](/docs/api-reference/files/create).
        /// </summary>
        /// <param name="filename">
        /// The name of the file to upload.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the uploaded file.<br/>
        /// See the [documentation on File purposes](/docs/api-reference/files/create#files-create-purpose).
        /// </param>
        /// <param name="bytes">
        /// The number of bytes in the file you are uploading.
        /// </param>
        /// <param name="mimeType">
        /// The MIME type of the file.<br/>
        /// This must fall within the supported MIME types for your file purpose. See the supported MIME types for assistants and vision.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Upload> CreateUploadAsync(
            string filename,
            global::G.CreateUploadRequestPurpose purpose,
            int bytes,
            string mimeType,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}