//HintName: G.IAssistantsClient.GetMessage.g.cs
#nullable enable

namespace G
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Retrieve a message.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "G_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::G.MessageObject> GetMessageAsync(
            string threadId,
            string messageId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}