//HintName: G.IChatmessageClient.GetAllChatMessages.g.cs
#nullable enable

namespace G
{
    public partial interface IChatmessageClient
    {
        /// <summary>
        /// List all chat messages<br/>
        /// Retrieve all chat messages for a specific chatflow.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="chatType"></param>
        /// <param name="order"></param>
        /// <param name="chatId"></param>
        /// <param name="memoryType">
        /// Example: Buffer Memory
        /// </param>
        /// <param name="sessionId"></param>
        /// <param name="startDate">
        /// Example: 2025-01-01T11:28:36.000Z
        /// </param>
        /// <param name="endDate">
        /// Example: 2025-01-13T11:28:36.000Z
        /// </param>
        /// <param name="feedback"></param>
        /// <param name="feedbackType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ChatMessage>> GetAllChatMessagesAsync(
            string id,
            global::G.GetAllChatMessagesChatType? chatType = default,
            global::G.GetAllChatMessagesOrder? order = default,
            string? chatId = default,
            string? memoryType = default,
            string? sessionId = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            bool? feedback = default,
            global::G.GetAllChatMessagesFeedbackType? feedbackType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}