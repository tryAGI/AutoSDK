//HintName: G.IConversationalAIClient.CreateConvaiAgentsByAgentIdAddSecret.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Add A Secret To The Agent Which Can Be Referenced In Tool Calls<br/>
        /// Uploads a file or reference a webpage for the agent to use as part of it's knowledge base
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddAgentSecretResponseModel> CreateConvaiAgentsByAgentIdAddSecretAsync(
            string agentId,
            global::G.BodyAddASecretToTheAgentWhichCanBeReferencedInToolCallsV1ConvaiAgentsAgentIdAddSecretPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add A Secret To The Agent Which Can Be Referenced In Tool Calls<br/>
        /// Uploads a file or reference a webpage for the agent to use as part of it's knowledge base
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="name">
        /// A name to help identify a particular agent secret<br/>
        /// Example: MY API KEY
        /// </param>
        /// <param name="secretValue">
        /// A value to be encrypted and used by the agent<br/>
        /// Example: sk_api_12354abc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddAgentSecretResponseModel> CreateConvaiAgentsByAgentIdAddSecretAsync(
            string agentId,
            string name,
            string secretValue,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}