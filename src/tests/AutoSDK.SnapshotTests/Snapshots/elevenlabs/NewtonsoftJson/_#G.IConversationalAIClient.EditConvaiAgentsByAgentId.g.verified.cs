//HintName: G.IConversationalAIClient.EditConvaiAgentsByAgentId.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Patches An Agent Settings<br/>
        /// Patches an Agent settings
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
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
        global::System.Threading.Tasks.Task<global::G.GetAgentResponseModel> EditConvaiAgentsByAgentIdAsync(
            string agentId,
            global::G.BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch request,
            bool? useToolIds = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Patches An Agent Settings<br/>
        /// Patches an Agent settings
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="useToolIds">
        /// Use tool ids instead of tools specs from request payload.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="conversationConfig">
        /// Conversation configuration for an agent
        /// </param>
        /// <param name="platformSettings">
        /// Platform settings for the agent are all settings that aren't related to the conversation orchestration and content.
        /// </param>
        /// <param name="name">
        /// A name to make the agent easier to find<br/>
        /// Example: My agent
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAgentResponseModel> EditConvaiAgentsByAgentIdAsync(
            string agentId,
            bool? useToolIds = default,
            string? xiApiKey = default,
            object? conversationConfig = default,
            object? platformSettings = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}