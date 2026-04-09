//HintName: G.IModelsClient.ListModels.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List Llm Models<br/>
        /// List available LLM models using the asynchronous implementation for improved performance.<br/>
        /// Returns Model format which extends LLMConfig with additional metadata fields.<br/>
        /// Legacy LLMConfig fields are marked as deprecated but still available for backward compatibility.
        /// </summary>
        /// <param name="providerCategory"></param>
        /// <param name="providerName"></param>
        /// <param name="providerType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Model>> ListModelsAsync(
            global::System.Collections.Generic.IList<global::G.ProviderCategory>? providerCategory = default,
            string? providerName = default,
            global::G.ProviderType? providerType = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}