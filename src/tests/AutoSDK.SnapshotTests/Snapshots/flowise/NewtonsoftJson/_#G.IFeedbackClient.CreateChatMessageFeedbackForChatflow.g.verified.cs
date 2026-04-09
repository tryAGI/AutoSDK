//HintName: G.IFeedbackClient.CreateChatMessageFeedbackForChatflow.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Create new chat message feedback<br/>
        /// Create new feedback for a specific chat flow.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatMessageFeedback> CreateChatMessageFeedbackForChatflowAsync(

            global::G.ChatMessageFeedback request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create new chat message feedback<br/>
        /// Create new feedback for a specific chat flow.
        /// </summary>
        /// <param name="id">
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatMessageFeedback> CreateChatMessageFeedbackForChatflowAsync(
            global::System.Guid? id = default,
            global::System.Guid? chatflowid = default,
            string? chatId = default,
            global::System.Guid? messageId = default,
            global::G.ChatMessageFeedbackRating? rating = default,
            string? content = default,
            global::System.DateTime? createdDate = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}