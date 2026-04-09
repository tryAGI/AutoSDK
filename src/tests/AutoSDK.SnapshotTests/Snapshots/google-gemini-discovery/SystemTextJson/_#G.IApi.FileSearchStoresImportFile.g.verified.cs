//HintName: G.IApi.FileSearchStoresImportFile.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Imports a `File` from File Service to a `FileSearchStore`.
        /// </summary>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Operation> FileSearchStoresImportFileAsync(
            string fileSearchStoresId,

            global::G.ImportFileRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Imports a `File` from File Service to a `FileSearchStore`.
        /// </summary>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="fileName">
        /// Required. The name of the `File` to import. Example: `files/abc-123`
        /// </param>
        /// <param name="customMetadata">
        /// Custom metadata to be associated with the file.
        /// </param>
        /// <param name="chunkingConfig">
        /// Parameters for telling the service how to chunk the file. inspired by google3/cloud/ai/platform/extension/lib/retrieval/config/chunker_config.proto
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Operation> FileSearchStoresImportFileAsync(
            string fileSearchStoresId,
            string? fileName = default,
            global::System.Collections.Generic.IList<global::G.CustomMetadata>? customMetadata = default,
            global::G.ChunkingConfig? chunkingConfig = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}