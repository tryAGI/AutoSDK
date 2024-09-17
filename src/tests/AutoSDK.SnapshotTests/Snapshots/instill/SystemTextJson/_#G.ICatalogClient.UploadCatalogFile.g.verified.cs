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
        /// <param name="type"></param>
        /// <param name="processStatus"></param>
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
            global::G.AllOf<global::G.FileType2?> type,
            string? fileUid = default,
            global::G.AllOf<global::G.FileProcessStatus2?>? processStatus = default,
            string? processOutcome = default,
            bool retrievable = default,
            string? content = default,
            string? ownerUid = default,
            string? creatorUid = default,
            string? catalogUid = default,
            global::System.DateTime createTime = default,
            global::System.DateTime updateTime = default,
            global::System.DateTime deleteTime = default,
            string? size = default,
            int totalChunks = default,
            int totalTokens = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}