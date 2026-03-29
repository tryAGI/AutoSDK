//HintName: G.IMessagesClient.RetrieveMessage.g.cs
#nullable enable

namespace G
{
    public partial interface IMessagesClient
    {
        /// <summary>
        /// Retrieve Message<br/>
        /// Retrieve a message by ID.
        /// </summary>
        /// <param name="messageId">
        /// The ID of the message in the format 'message-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.LettaMessageUnion>> RetrieveMessageAsync(
            string messageId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}