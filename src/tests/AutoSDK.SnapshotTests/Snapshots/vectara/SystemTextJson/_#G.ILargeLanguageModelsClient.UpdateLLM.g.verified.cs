//HintName: G.ILargeLanguageModelsClient.UpdateLLM.g.cs
#nullable enable

namespace G
{
    public partial interface ILargeLanguageModelsClient
    {
        /// <summary>
        /// Update an LLM<br/>
        /// Update an existing LLM's configuration. This endpoint allows partial updates - only provide fields you want to change. Only the name field is immutable.<br/>
        /// The updated LLM will be tested before saving to ensure credentials are valid.<br/>
        /// **Updatable fields:**<br/>
        /// - `description` - LLM description<br/>
        /// - `type` - LLM type (openai-compatible, vertex-ai, etc.)<br/>
        /// - `model` - Model identifier<br/>
        /// - `uri` - API endpoint<br/>
        /// - `auth` - Authentication credentials (including service account key_json)<br/>
        /// - `headers` - Additional HTTP headers (for openai-compatible and anthropic types)<br/>
        /// - `enabled` - Whether the LLM is enabled<br/>
        /// - `capabilities` - Model capabilities (image support, context limit, tool calling)<br/>
        /// **Immutable fields:**<br/>
        /// - `id` - System-generated identifier<br/>
        /// - `name` - LLM name<br/>
        /// Built-in LLMs (system-provided models) cannot be updated.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="llmId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Llm> UpdateLLMAsync(
            string llmId,

            global::G.UpdateLLMRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an LLM<br/>
        /// Update an existing LLM's configuration. This endpoint allows partial updates - only provide fields you want to change. Only the name field is immutable.<br/>
        /// The updated LLM will be tested before saving to ensure credentials are valid.<br/>
        /// **Updatable fields:**<br/>
        /// - `description` - LLM description<br/>
        /// - `type` - LLM type (openai-compatible, vertex-ai, etc.)<br/>
        /// - `model` - Model identifier<br/>
        /// - `uri` - API endpoint<br/>
        /// - `auth` - Authentication credentials (including service account key_json)<br/>
        /// - `headers` - Additional HTTP headers (for openai-compatible and anthropic types)<br/>
        /// - `enabled` - Whether the LLM is enabled<br/>
        /// - `capabilities` - Model capabilities (image support, context limit, tool calling)<br/>
        /// **Immutable fields:**<br/>
        /// - `id` - System-generated identifier<br/>
        /// - `name` - LLM name<br/>
        /// Built-in LLMs (system-provided models) cannot be updated.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="llmId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Llm> UpdateLLMAsync(
            string llmId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}