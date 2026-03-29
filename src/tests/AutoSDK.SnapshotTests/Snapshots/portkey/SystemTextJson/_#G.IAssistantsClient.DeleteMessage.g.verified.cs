//HintName: G.IAssistantsClient.DeleteMessage.g.cs
#nullable enable

namespace G
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Deletes a message.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteMessageResponse> DeleteMessageAsync(
            string threadId,
            string messageId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}