//HintName: G.IConversationalAiClient.CreateFolder.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAiClient
    {
        /// <summary>
        /// Create Folder<br/>
        /// Create a folder used for grouping documents together.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddKnowledgeBaseResponseModel> CreateFolderAsync(

            global::G.BodyCreateFolderV1ConvaiKnowledgeBaseFolderPost request,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Folder<br/>
        /// Create a folder used for grouping documents together.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="name">
        /// A custom, human-readable name for the document.
        /// </param>
        /// <param name="parentFolderId">
        /// If set, the created document or folder will be placed inside the given folder.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddKnowledgeBaseResponseModel> CreateFolderAsync(
            string name,
            string? xiApiKey = default,
            string? parentFolderId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}