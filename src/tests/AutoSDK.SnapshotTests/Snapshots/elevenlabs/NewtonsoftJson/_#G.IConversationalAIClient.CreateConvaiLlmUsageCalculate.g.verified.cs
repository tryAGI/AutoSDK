//HintName: G.IConversationalAIClient.CreateConvaiLlmUsageCalculate.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Calculate Expected Llm Usage<br/>
        /// Returns a list of LLM models and the expected cost for using them based on the provided values.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LLMUsageCalculatorResponseModel> CreateConvaiLlmUsageCalculateAsync(
            global::G.LLMUsageCalculatorPublicRequestModel request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Calculate Expected Llm Usage<br/>
        /// Returns a list of LLM models and the expected cost for using them based on the provided values.
        /// </summary>
        /// <param name="promptLength">
        /// Length of the prompt in characters.
        /// </param>
        /// <param name="numberOfPages">
        /// Pages of content in PDF documents or URLs in the agent's knowledge base.
        /// </param>
        /// <param name="ragEnabled">
        /// Whether RAG is enabled.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LLMUsageCalculatorResponseModel> CreateConvaiLlmUsageCalculateAsync(
            int promptLength,
            int numberOfPages,
            bool ragEnabled,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}