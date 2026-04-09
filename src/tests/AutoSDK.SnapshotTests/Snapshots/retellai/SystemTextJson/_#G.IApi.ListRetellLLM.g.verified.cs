//HintName: G.IApi.ListRetellLLM.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List all Retell LLM Response Engines that can be attached to an agent.
        /// </summary>
        /// <param name="limit">
        /// Example: 50
        /// </param>
        /// <param name="paginationKey">
        /// Example: llm_1ffdb9717444d0e77346838911
        /// </param>
        /// <param name="paginationKeyVersion">
        /// Example: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.RetellLLMResponse>> ListRetellLLMAsync(
            int? limit = default,
            string? paginationKey = default,
            int? paginationKeyVersion = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}