//HintName: G.Ix__AppClient.AppPublicServiceRestartPlaygroundConversation.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__AppClient
    {
        /// <summary>
        /// Restart Playground Conversation<br/>
        /// Creates a new conversation and uses the auth user UID as creator UID and<br/>
        /// auto-generates a new conversation ID on the behalf of auth user.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RestartPlaygroundConversationResponse> AppPublicServiceRestartPlaygroundConversationAsync(
            string namespaceId,
            string appId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}