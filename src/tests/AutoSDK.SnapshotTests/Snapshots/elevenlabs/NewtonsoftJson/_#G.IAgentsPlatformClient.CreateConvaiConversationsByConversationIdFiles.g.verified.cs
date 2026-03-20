//HintName: G.IAgentsPlatformClient.CreateConvaiConversationsByConversationIdFiles.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {

        /// <summary>
        /// Upload File<br/>
        /// Upload an image or PDF file for a conversation. Returns a unique file ID that can be used to reference the file in the conversation.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConvAIFileUploadResponseModel> CreateConvaiConversationsByConversationIdFilesAsync(
            string conversationId,

            global::G.BodyUploadFileV1ConvaiConversationsConversationIdFilesPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload File<br/>
        /// Upload an image or PDF file for a conversation. Returns a unique file ID that can be used to reference the file in the conversation.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="file">
        /// Image or PDF file to upload
        /// </param>
        /// <param name="filename">
        /// Image or PDF file to upload
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConvAIFileUploadResponseModel> CreateConvaiConversationsByConversationIdFilesAsync(
            string conversationId,
            byte[] file,
            string filename,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}