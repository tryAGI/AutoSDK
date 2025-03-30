//HintName: G.IConversationalAIClient.CreateConvaiConversationsByConversationIdFeedback.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Send Conversation Feedback<br/>
        /// Send the feedback for the given conversation
        /// </summary>
        /// <param name="conversationId">
        /// The id of the conversation you're taking the action on.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateConvaiConversationsByConversationIdFeedbackAsync(
            string conversationId,
            global::G.BodySendConversationFeedbackV1ConvaiConversationsConversationIdFeedbackPost request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Send Conversation Feedback<br/>
        /// Send the feedback for the given conversation
        /// </summary>
        /// <param name="conversationId">
        /// The id of the conversation you're taking the action on.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="feedback"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateConvaiConversationsByConversationIdFeedbackAsync(
            string conversationId,
            global::G.UserFeedbackScore feedback,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}