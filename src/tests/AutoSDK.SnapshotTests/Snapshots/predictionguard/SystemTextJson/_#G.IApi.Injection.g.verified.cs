//HintName: G.IApi.Injection.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Injection<br/>
        /// Injection detects potential prompt injection attacks.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.InjectionResponse200> InjectionAsync(

            global::G.InjectionRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Injection<br/>
        /// Injection detects potential prompt injection attacks.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="detect">
        /// Whether to detect potential injection attacks.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.InjectionResponse200> InjectionAsync(
            global::G.InjectionPostRequestBodyContentApplicationJsonSchemaPrompt prompt,
            bool detect,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}