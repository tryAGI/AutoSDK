//HintName: G.IFeedbackClient.UpdateChatMessageFeedbackForChatflow.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Update chat message feedback<br/>
        /// Update a specific feedback
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatMessageFeedback> UpdateChatMessageFeedbackForChatflowAsync(
            string id,

            global::G.ChatMessageFeedback request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update chat message feedback<br/>
        /// Update a specific feedback
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId">
        /// Unique identifier for the feedback
        /// </param>
        /// <param name="chatflowid">
        /// Identifier for the chat flow
        /// </param>
        /// <param name="chatId">
        /// Identifier for the chat
        /// </param>
        /// <param name="messageId">
        /// Identifier for the message
        /// </param>
        /// <param name="rating">
        /// Rating for the message
        /// </param>
        /// <param name="content">
        /// Feedback content
        /// </param>
        /// <param name="createdDate">
        /// Date and time when the feedback was created
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatMessageFeedback> UpdateChatMessageFeedbackForChatflowAsync(
            string id,
            global::System.Guid? requestId = default,
            global::System.Guid? chatflowid = default,
            string? chatId = default,
            global::System.Guid? messageId = default,
            global::G.ChatMessageFeedbackRating? rating = default,
            string? content = default,
            global::System.DateTime? createdDate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}