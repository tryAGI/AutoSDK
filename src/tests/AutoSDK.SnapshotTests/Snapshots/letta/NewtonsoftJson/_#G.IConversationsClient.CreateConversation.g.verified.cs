//HintName: G.IConversationsClient.CreateConversation.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Create Conversation<br/>
        /// Create a new conversation for an agent.
        /// </summary>
        /// <param name="agentId">
        /// The agent ID to create a conversation for
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Conversation> CreateConversationAsync(
            string agentId,

            global::G.CreateConversation request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Conversation<br/>
        /// Create a new conversation for an agent.
        /// </summary>
        /// <param name="agentId">
        /// The agent ID to create a conversation for
        /// </param>
        /// <param name="summary">
        /// A summary of the conversation.
        /// </param>
        /// <param name="isolatedBlockLabels">
        /// List of block labels that should be isolated (conversation-specific) rather than shared across conversations. New blocks will be created as copies of the agent's blocks with these labels.
        /// </param>
        /// <param name="model">
        /// The model handle for this conversation (overrides agent's model). Format: provider/model-name.
        /// </param>
        /// <param name="modelSettings">
        /// The model settings for this conversation (overrides agent's model settings).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Conversation> CreateConversationAsync(
            string agentId,
            string? summary = default,
            global::System.Collections.Generic.IList<string>? isolatedBlockLabels = default,
            string? model = default,
            global::G.ModelSettingsVariant16? modelSettings = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}