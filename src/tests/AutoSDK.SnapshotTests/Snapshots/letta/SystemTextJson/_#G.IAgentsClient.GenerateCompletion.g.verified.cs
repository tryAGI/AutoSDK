//HintName: G.IAgentsClient.GenerateCompletion.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Generate Completion<br/>
        /// Generate a completion directly from the LLM provider using the agent's configuration.<br/>
        /// This endpoint makes a direct request to the LLM provider without any agent processing:<br/>
        /// - No memory or context retrieval<br/>
        /// - No tool calling<br/>
        /// - No message persistence<br/>
        /// - No agent state modification<br/>
        /// Simply provide a prompt, and the endpoint formats it as a user message.<br/>
        /// Optionally include a system_prompt for context/instructions.<br/>
        /// The agent's LLM configuration (model, credentials, settings) is used by default.<br/>
        /// Use override_model to switch to a different model/provider while still using<br/>
        /// the organization's configured providers.<br/>
        /// Example use cases:<br/>
        /// - Quick LLM queries without agent overhead<br/>
        /// - Testing different models with the same prompt<br/>
        /// - Simple chat completions using agent's credentials<br/>
        /// - Comparing model outputs on identical prompts
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GenerateResponse> GenerateCompletionAsync(
            string agentId,

            global::G.GenerateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Completion<br/>
        /// Generate a completion directly from the LLM provider using the agent's configuration.<br/>
        /// This endpoint makes a direct request to the LLM provider without any agent processing:<br/>
        /// - No memory or context retrieval<br/>
        /// - No tool calling<br/>
        /// - No message persistence<br/>
        /// - No agent state modification<br/>
        /// Simply provide a prompt, and the endpoint formats it as a user message.<br/>
        /// Optionally include a system_prompt for context/instructions.<br/>
        /// The agent's LLM configuration (model, credentials, settings) is used by default.<br/>
        /// Use override_model to switch to a different model/provider while still using<br/>
        /// the organization's configured providers.<br/>
        /// Example use cases:<br/>
        /// - Quick LLM queries without agent overhead<br/>
        /// - Testing different models with the same prompt<br/>
        /// - Simple chat completions using agent's credentials<br/>
        /// - Comparing model outputs on identical prompts
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="prompt">
        /// The prompt/message to send to the LLM
        /// </param>
        /// <param name="systemPrompt">
        /// Optional system prompt to prepend to the conversation
        /// </param>
        /// <param name="overrideModel">
        /// Model handle to use instead of agent's default (e.g., 'openai/gpt-4', 'anthropic/claude-3-5-sonnet')
        /// </param>
        /// <param name="responseSchema">
        /// JSON schema for structured output. When provided, the LLM will be forced to return a response matching this schema via tool calling. The schema should follow JSON Schema format with 'properties' and optionally 'required' fields.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GenerateResponse> GenerateCompletionAsync(
            string agentId,
            string prompt,
            string? systemPrompt = default,
            string? overrideModel = default,
            object? responseSchema = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}