//HintName: G.IOllamaClient.TestConnection.g.cs
#nullable enable

namespace G
{
    public partial interface IOllamaClient
    {
        /// <summary>
        /// Test connection to Ollama instance<br/>
        /// Validates that the provided Ollama URL is reachable. URL may be provided with or without /v1 suffix (e.g., http://localhost:11434 or http://localhost:11434/v1). The /v1 suffix will be automatically removed for connection testing. For inference, use the URL with /v1 suffix.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OllamaConnectionTestResponse> TestConnectionAsync(

            global::G.OllamaInstanceBaseUrlRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test connection to Ollama instance<br/>
        /// Validates that the provided Ollama URL is reachable. URL may be provided with or without /v1 suffix (e.g., http://localhost:11434 or http://localhost:11434/v1). The /v1 suffix will be automatically removed for connection testing. For inference, use the URL with /v1 suffix.
        /// </summary>
        /// <param name="baseUrl">
        /// Base URL of the Ollama instance. May include /v1 suffix which will be automatically removed for connection testing. For inference, use the URL with /v1 suffix for OpenAI-compatible endpoints.<br/>
        /// Example: http://localhost:11434/v1
        /// </param>
        /// <param name="apiKey">
        /// Optional API key for authenticated Ollama instances. If provided, will be sent as Bearer token in Authorization header.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OllamaConnectionTestResponse> TestConnectionAsync(
            string baseUrl,
            string? apiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}