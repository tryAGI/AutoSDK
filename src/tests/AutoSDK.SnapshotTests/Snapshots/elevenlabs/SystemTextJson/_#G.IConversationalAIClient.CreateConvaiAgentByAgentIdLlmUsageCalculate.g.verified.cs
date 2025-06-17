//HintName: G.IConversationalAIClient.CreateConvaiAgentByAgentIdLlmUsageCalculate.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Calculate Expected Llm Usage For An Agent<br/>
        /// Calculates expected number of LLM tokens needed for the specified agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LLMUsageCalculatorResponseModel> CreateConvaiAgentByAgentIdLlmUsageCalculateAsync(
            string agentId,
            global::G.LLMUsageCalculatorRequestModel request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Calculate Expected Llm Usage For An Agent<br/>
        /// Calculates expected number of LLM tokens needed for the specified agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="promptLength">
        /// Length of the prompt in characters.
        /// </param>
        /// <param name="numberOfPages">
        /// Pages of content in pdf documents OR urls in agent's Knowledge Base.
        /// </param>
        /// <param name="ragEnabled">
        /// Whether RAG is enabled.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LLMUsageCalculatorResponseModel> CreateConvaiAgentByAgentIdLlmUsageCalculateAsync(
            string agentId,
            string? xiApiKey = default,
            int? promptLength = default,
            int? numberOfPages = default,
            bool? ragEnabled = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}