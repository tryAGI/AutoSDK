//HintName: G.IProxyClient.Proxycompletions.g.cs
#nullable enable

namespace G
{
    public partial interface IProxyClient
    {
        /// <summary>
        /// Proxy completions<br/>
        /// Proxy a completions request to the specified model, converting its format as needed. Will cache if temperature=0 or seed is set.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ProxycompletionsAsync(

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Proxy completions<br/>
        /// Proxy a completions request to the specified model, converting its format as needed. Will cache if temperature=0 or seed is set.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ProxycompletionsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}