//HintName: G.ICatalogClient.UploadCatalogFile.g.cs
#nullable enable

namespace G
{
    public partial interface ICatalogClient
    {
        /// <summary>
        /// Create a file
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UploadCatalogFileResponse> UploadCatalogFileAsync(
            string namespaceId,
            string catalogId,
            global::G.File request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a file
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="fileUid"></param>
        /// <param name="name"></param>
        /// <param name="processStatus">
        /// - FILE_PROCESS_STATUS_NOTSTARTED: NOTSTARTED<br/>
        ///  - FILE_PROCESS_STATUS_WAITING: file is waiting for embedding process<br/>
        ///  - FILE_PROCESS_STATUS_CONVERTING: file is converting<br/>
        ///  - FILE_PROCESS_STATUS_CHUNKING: file is chunking<br/>
        ///  - FILE_PROCESS_STATUS_EMBEDDING: file is embedding<br/>
        ///  - FILE_PROCESS_STATUS_COMPLETED: completed<br/>
        ///  - FILE_PROCESS_STATUS_FAILED: failed
        /// </param>
        /// <param name="type">
        /// - FILE_TYPE_TEXT: text<br/>
        ///  - FILE_TYPE_PDF: PDF<br/>
        ///  - FILE_TYPE_MARKDOWN: MARKDOWN<br/>
        ///  - FILE_TYPE_PNG: PNG(not supported yet)<br/>
        ///  - FILE_TYPE_JPEG: JPEG(not supported yet)<br/>
        ///  - FILE_TYPE_JPG: JPG(not supported yet)<br/>
        ///  - FILE_TYPE_HTML: HTML<br/>
        ///  - FILE_TYPE_DOCX: DOCX<br/>
        ///  - FILE_TYPE_DOC: DOC<br/>
        ///  - FILE_TYPE_PPT: PPT<br/>
        ///  - FILE_TYPE_PPTX: PPTX<br/>
        ///  - FILE_TYPE_XLS: XLS(not supported yet)<br/>
        ///  - FILE_TYPE_XLSX: XLSX
        /// </param>
        /// <param name="processOutcome"></param>
        /// <param name="retrievable"></param>
        /// <param name="content"></param>
        /// <param name="ownerUid"></param>
        /// <param name="creatorUid"></param>
        /// <param name="catalogUid"></param>
        /// <param name="createTime"></param>
        /// <param name="updateTime"></param>
        /// <param name="deleteTime"></param>
        /// <param name="size"></param>
        /// <param name="totalChunks"></param>
        /// <param name="totalTokens"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UploadCatalogFileResponse> UploadCatalogFileAsync(
            string namespaceId,
            string catalogId,
            string name,
            global::G.FileType type,
            string? fileUid = default,
            global::G.FileProcessStatus? processStatus = default,
            string? processOutcome = default,
            bool? retrievable = default,
            string? content = default,
            string? ownerUid = default,
            string? creatorUid = default,
            string? catalogUid = default,
            global::System.DateTime? createTime = default,
            global::System.DateTime? updateTime = default,
            global::System.DateTime? deleteTime = default,
            string? size = default,
            int? totalChunks = default,
            int? totalTokens = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}