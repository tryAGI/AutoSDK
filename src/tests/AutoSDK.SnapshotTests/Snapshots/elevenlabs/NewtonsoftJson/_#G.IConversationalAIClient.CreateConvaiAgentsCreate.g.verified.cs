//HintName: G.IConversationalAIClient.CreateConvaiAgentsCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Create Agent<br/>
        /// Create an agent from a config object
        /// </summary>
        /// <param name="useToolIds">
        /// Use tool ids instead of tools specs from request payload.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateAgentResponseModel> CreateConvaiAgentsCreateAsync(
            global::G.BodyCreateAgentV1ConvaiAgentsCreatePost request,
            bool? useToolIds = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Agent<br/>
        /// Create an agent from a config object
        /// </summary>
        /// <param name="useToolIds">
        /// Use tool ids instead of tools specs from request payload.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="conversationConfig"></param>
        /// <param name="platformSettings"></param>
        /// <param name="name">
        /// A name to make the agent easier to find<br/>
        /// Example: My agent
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateAgentResponseModel> CreateConvaiAgentsCreateAsync(
            global::G.ConversationalConfigAPIModelInput conversationConfig,
            bool? useToolIds = default,
            string? xiApiKey = default,
            global::G.AgentPlatformSettingsRequestModel? platformSettings = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}