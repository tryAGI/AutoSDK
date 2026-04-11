//HintName: G.ILlmProviderKeyClient.StoreLlmProviderApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface ILlmProviderKeyClient
    {
        /// <summary>
        /// Store LLM Provider's ApiKey<br/>
        /// Store LLM Provider's ApiKey
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task StoreLlmProviderApiKeyAsync(

            global::G.ProviderApiKeyWrite request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store LLM Provider's ApiKey<br/>
        /// Store LLM Provider's ApiKey
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="apiKey"></param>
        /// <param name="name"></param>
        /// <param name="providerName">
        /// Provider name - required for custom LLM and Bedrock providers to uniquely identify them (e.g., 'ollama', 'vllm', 'Bedrock us-east-1'). Must not be blank for custom and Bedrock providers. Should not be set for standard providers (OpenAI, Anthropic, etc.). This requirement is conditional and validation is enforced programmatically.<br/>
        /// Example: ollama
        /// </param>
        /// <param name="headers"></param>
        /// <param name="configuration"></param>
        /// <param name="baseUrl"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task StoreLlmProviderApiKeyAsync(
            global::G.ProviderApiKeyWriteProvider provider,
            string? apiKey = default,
            string? name = default,
            string? providerName = default,
            global::System.Collections.Generic.Dictionary<string, string>? headers = default,
            global::System.Collections.Generic.Dictionary<string, string>? configuration = default,
            string? baseUrl = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}