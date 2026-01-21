//HintName: G.IConversationalAIClient.CreateConvaiAgentsByAgentIdAvatar.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Post Agent Avatar<br/>
        /// Sets the avatar for an agent displayed in the widget
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostAgentAvatarResponseModel> CreateConvaiAgentsByAgentIdAvatarAsync(
            string agentId,
            global::G.BodyPostAgentAvatarV1ConvaiAgentsAgentIdAvatarPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Post Agent Avatar<br/>
        /// Sets the avatar for an agent displayed in the widget
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="avatarFile">
        /// An image file to be used as the agent's avatar.
        /// </param>
        /// <param name="avatarFilename">
        /// An image file to be used as the agent's avatar.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostAgentAvatarResponseModel> CreateConvaiAgentsByAgentIdAvatarAsync(
            string agentId,
            byte[] avatarFile,
            string avatarFilename,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}