//HintName: G.IAgentsPlatformClient.DeleteConvaiConversationsByConversationIdFilesByFileId.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {

        /// <summary>
        /// Delete File Upload<br/>
        /// Remove a file upload from a conversation. Only possible if the file hasn't already been used in the conversation.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="fileId"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConvAIFileUploadResponseModel> DeleteConvaiConversationsByConversationIdFilesByFileIdAsync(
            string conversationId,
            string fileId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}