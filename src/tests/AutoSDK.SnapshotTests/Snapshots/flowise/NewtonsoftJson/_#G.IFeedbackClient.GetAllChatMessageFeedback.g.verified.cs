//HintName: G.IFeedbackClient.GetAllChatMessageFeedback.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// List all chat message feedbacks for a chatflow<br/>
        /// Retrieve all feedbacks for a chatflow
        /// </summary>
        /// <param name="id"></param>
        /// <param name="chatId"></param>
        /// <param name="sortOrder">
        /// Default Value: asc
        /// </param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ChatMessageFeedback>> GetAllChatMessageFeedbackAsync(
            string id,
            string? chatId = default,
            global::G.GetAllChatMessageFeedbackSortOrder? sortOrder = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}