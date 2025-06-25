//HintName: G.IConversationalAIClient.GetConvaiConversationGetSignedUrl.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Get Signed Url<br/>
        /// Get a signed url to start a conversation with an agent with an agent that requires authorization
        /// </summary>
        /// <param name="agentId">
        /// The id of the agent you're taking the action on.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConversationSignedUrlResponseModel> GetConvaiConversationGetSignedUrlAsync(
            string agentId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}